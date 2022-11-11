using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21_Server
{
    internal class Dealer
    {
        private Deck _gameDeck;
        //IPAddress player1, player2;
        List<string> playerScores = new List<string>();
        int Bets;
        public Dealer(Deck deck)
        {
            this._gameDeck = deck;
        }

        public void DealCardFaceDown(Player pRequest, Player pOther)
        {
            Card deal = _gameDeck.TakeCardFromDeck();

            //The player who requested will receive the card given
            pRequest.ReceiveCard(deal, true);
            //The other player receives the card 'facing down'
            pOther.ReceiveCard("*****");
        }

        public void DealCardFaceUp(Player pRequest, Player pOther)
        {
            Card deal = _gameDeck.TakeCardFromDeck();

            //Both players receive the card given
            pRequest.ReceiveCard(deal, true);
            pOther.ReceiveCard(deal, false);
        }
        public int ReceiveBets(int b1, int b2)
        {
            Bets = b1 + b2;
            return Bets;
        }

        public void StoreScore(string s)
        {
            playerScores.Add(s);
        }

        public void DecideWinner()
        {
            string winner;
            int maxPoints = 0;
            int minCards = 52;

            foreach (string sc in playerScores)
            {
                string[] s = sc.Split(' ');
                int points = int.Parse(s[0]);
                int cardNum = int.Parse(s[1]);
                string posWinner = s[2];

                //The first one with the conditions will win always in case of draw.
                if (points >= maxPoints && points <= 21 && cardNum < minCards)
                {
                    winner = posWinner;
                    maxPoints = points;
                    minCards = cardNum;
                }

            }
        }
    }
}
