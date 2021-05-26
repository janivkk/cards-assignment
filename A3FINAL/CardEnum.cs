using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    //Enumerating cards with values
    public enum eCard
    {
        Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8,
        Nine = 9, Ten = 10, J = 11, Q = 12, K = 13, A = 14
    }

    //Enumerating suits
    public enum eSuit
    {
        H, C, D, S //hearts, clubs, diamonds, spades
    }

    class CardEnum : IComparable<CardEnum>
    {
        //Encapsulating
        protected eCard face { get; set; }
        protected eSuit suit { get; set; }
        
        //Constructor
        public CardEnum(eCard FaceCard, eSuit SuitCard)
        {
            face = FaceCard;
            suit = SuitCard;
        }

        //Initilises the interface of comparing values together, IComparable<T>
        public int CompareTo(CardEnum o)
        {
            if (suit > o.suit)
            {
                return 1;
            }

            if (suit < o.suit)
            {
                return -1;
            }
            return face > o.face ? 1 : -1;
        }

        //Override, displays all the enumaratated cards
        public override string ToString()
        {
            return $"{face} {suit}";
        }
    }
}
