using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21_Server
{
    internal class Card
    {
        public string Value { get; }
        public string Suit { get; }

        public Card(string val, string su)
        {
            this.Value = val;
            this.Suit = su;
        }

        
        public override string ToString()
        {
            return Value + " " + Suit;
        }
    }
}
