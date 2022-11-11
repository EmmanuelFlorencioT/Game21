using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game21_Server
{
    internal class Player
    {
        private List<Card> _hand;
        private List<string> _oponentHand;

        public Player()
        {
            _hand = new List<Card>();
            _oponentHand = new List<string>();
        }

        public void ReceiveCard(Card c, bool isMine)
        {
            if (isMine)
            {
                _hand.Add(c);
            }
            else
            {
                _oponentHand.Add(c.ToString());
            }
        }
        public void ReceiveCard(String s)
        {

            _oponentHand.Add(s);
        }

        public void PrintHand(ListBox l)
        {
            l.Items.Clear();
            foreach(Card c in _hand)
            {
                l.Items.Add(c.ToString());
            }
        }
        public void PrintOponentHand(ListBox l)
        {
            l.Items.Clear();
            foreach(string s in _oponentHand)
            {
                l.Items.Add(s);
            }
        }

        private int CountPoints()
        {
            int points = 0;
            int containsA = 0;

            foreach (Card c in _hand)
            {
                if (c.Value != "A")
                    points += int.Parse(c.Value);
                else
                    containsA++;
            }

            if (containsA > 0)
            {
                for (int i = containsA; i > 0; i--)
                {
                    if (21 - points >= 11)
                        points += 11;
                    else
                        points += 1;
                }
            }

            return points;
        }

        public string LayDownDeck()
        {
            string myGame = "";
            myGame += CountPoints().ToString() + " " + _hand.Count.ToString() + " " + "IP_PLAYER";

            return myGame;
        }
    }
}
