using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    //Enumerating cards
    public enum eCard
    {
        Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8,
        Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13, Ace = 14
    }

    //Enumerating suits
    public enum eSuit
    {
        Hearts, Diamonds, Clubs, Spades
    }

    class CardEnum
    {
        public eCard face;
        public eSuit suit;

        //Encapsulating
        //public eCard _faceC { get; set; }
        //public eSuit _suitC { get; set; }
        
        //Constructor
        public CardEnum(eCard FaceCard, eSuit SuitCard)
        {
            face = FaceCard;
            suit = SuitCard;
        }

        //Override, displays all the enumaratated cards
        public override string ToString()
        {
            return $"{face} of {suit}";
        }
    }
}
