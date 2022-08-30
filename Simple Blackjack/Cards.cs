using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Blackjack
{
    struct Cards
    {

        private string cardColor;
        private int cardValue;

        public string CardColor { get => cardColor; set => cardColor = value; }
        public int CardValue { get => cardValue; set => cardValue = value; }

        public Cards(string color, int value)
        {
            this.cardColor = color;
            this.cardValue = value;
        }

    }

}
