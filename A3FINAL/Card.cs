using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    class Card
    {
        private string _suit;
        private string _face;

        //Encapsulation
        public string suitCard
        {
            get { return _suit; } set { _suit = value; }
        }

        public string faceCard
        {
            get { return _face; } set { _face = value; }
        }

        //Giving each card its individual value to represent it in a game
        public enum Values
        {
            Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7,
            Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13, Ace = 14
        }

        //Constructor
        public Card(string suitCard, string faceCard)
        {
            _suit = suitCard;
            _face = faceCard;
            Values _value;
        }

        //This overrides the array meaning, it converts it to readable data when program runs 
        public override string ToString()
        {
            return _face + " " + _suit;
            //return _face + " " _suit + "Value: " + _value;
        }
    }
}
