using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game21_Server
{
    internal class Deck
    {
        private List<Card> deckList; //Used to shuffle cards
        private Queue<Card> _deck;
        public const int _deckDimension = 52;

        //Creates and shuffles the deck
        public Deck()
        {
            string[] values = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
            string[] suits = { "H", "D", "C", "S"};
            deckList = new List<Card>(_deckDimension);

            foreach(string v in values)
            {
                foreach(string s in suits)
                {
                    deckList.Add(new Card(v, s));
                }
            }

            Shuffle();
            _deck = new Queue<Card>(deckList);
        }

        private void SwapCard(int a, int b)
        {
            Card cd = deckList[a];
            deckList[a] = deckList[b];
            deckList[b] = cd;
        }

        private void Shuffle() //Shuffle the deckList
        {
            var rnd = new Random();
            int i = 0;

            int first;
            int second;

            while (i < 10000)
            {
                first = rnd.Next(0, _deckDimension - 1);
                do
                {
                    second = rnd.Next(0, _deckDimension - 1);
                }
                while (first == second);

                SwapCard(first, second);
                i++;
            }
        }

        public Card TakeCardFromDeck()
        {
            Card c;
            try
            {
                c = _deck.Dequeue();
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("No cards left\n{0}", e.ToString());
                c = null;
            }
            return c;
        }

    }
}
