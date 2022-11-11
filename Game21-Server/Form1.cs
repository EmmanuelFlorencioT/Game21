using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game21_Server
{
    public partial class Form1 : Form
    {
        Listener l = new Listener();
        
        //1st Players must present themselves to Server
        Player p1 = new Player();
        Player p2 = new Player();

        static Deck deck = new Deck();
        Dealer dl = new Dealer(deck);


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIntroPlayers_Click(object sender, EventArgs e)
        {
            l.StartIntroduction();
        }

        private void BtnStopIntro_Click(object sender, EventArgs e)
        {
            if (l.CheckClients() != null)
            {
                string[] playerIPs = l.CheckClients().Split(' ');
                LabPlayer1IP.Text += playerIPs[0];
                LabPlayer2IP.Text += playerIPs[1];
            }
            else
                MessageBox.Show("Error connecting to players");
        }
    }
}
