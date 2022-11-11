using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Game21_Server
{
    internal class Listener
    {
        private Socket listenerSocket; //Socket that will listen incoming connections
        private short portNo = 5000;
        private EndPoint client1 = null;
        private EndPoint client2 = null;
        private byte[] byteData = new byte[1024];

        public Listener()
        {
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listenerSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            listenerSocket.Bind(new IPEndPoint(IPAddress.Any, portNo));
        }

        public void StartIntroduction()
        {
            EndPoint newClientEP = new IPEndPoint(IPAddress.Any, 0);
            Array.Clear(byteData, 0, byteData.Length);//Clear array before begining to receive
            listenerSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref newClientEP, DoIntroduction, newClientEP);
        }

        private void DoIntroduction(IAsyncResult iar)
        {
            EndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);
            int dataLen = 0;
            byte[] data = null;
            try
            {
                dataLen = listenerSocket.EndReceiveFrom(iar, ref clientEP);
                data = new byte[dataLen];
                Array.Copy(this.byteData, data, dataLen);
                string receiveBuff = Encoding.ASCII.GetString(data);
                byte[] ackMssg = Encoding.ASCII.GetBytes("Server speaking back!");
                listenerSocket.BeginSendTo(ackMssg, 0, ackMssg.Length, SocketFlags.None, clientEP, DoSendTo, clientEP);
            }
            finally
            {
                if (client1 == null)
                {
                    client1 = clientEP;
                    EndPoint newClientEP = new IPEndPoint(IPAddress.Any, 0);
                    listenerSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref newClientEP, DoIntroduction, newClientEP);
                }
                else
                {
                    client2 = clientEP;
                }
            }
        }

        public void DoSendTo(IAsyncResult iar)
        {
            listenerSocket.EndSendTo(iar);
            Console.WriteLine("Sent the ACK");
        }

        //Returns the clients IP adderesses as a string
        public string CheckClients()
        {
            if(client1 != null && client2 != null)
            {
                return ((IPEndPoint)client1).Address.ToString() + " " + ((IPEndPoint)client2).Address.ToString();
            }
            return null;
        }
    }
}
