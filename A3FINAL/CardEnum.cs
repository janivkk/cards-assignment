using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    //Enumerating cards
    public enum eCard
    {
        Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, J, Q, K, A
    }

    //Enumerating suits
    public enum eSuit
    {
        H, C, D, S //hearts, clubs, diamonds, spades
    }

    class CardEnum : IComparable<CardEnum>
    {
        //public eCard face;
        //public eSuit suit;

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
