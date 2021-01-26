using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13
{
    internal class Card
    {
        public string Face { get; set; }
        public Suit Suit { get; set; }

        public override string ToString()
        {
            string card = $"({Face} {Suit})";
            return card;
        }
    }
}
