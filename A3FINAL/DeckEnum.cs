using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    class DeckEnum : IComparable
    {
        public readonly List<CardEnum> DeckListEnum = new List<CardEnum>();

        //Constructor
        public DeckEnum()
        {
            //DeckListEnum = new List<CardEnum>();
            int s = Enum.GetNames(typeof(eSuit)).Length;
            int c = Enum.GetNames(typeof(eCard)).Length;

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    DeckListEnum.Add(new CardEnum((eCard)face, (eSuit)suit));
                }
            }

        }

        public int CountTheDeck => DeckListEnum.Count;

        //Shuffling player's deck 
        public void Shuffle()
        {
            Random r = new Random();
            int x = CountTheDeck;
            while (x > 1)
            {
                x--;
                int i = r.Next(x + 1);
                CardEnum r_card = DeckListEnum[i];
                DeckListEnum[i] = DeckListEnum[x];
                DeckListEnum[x] = r_card;
            }
        }

        //Hand for a player
        public void Hand()
        {
            foreach (CardEnum cardDeck in DeckListEnum)
            {
                Console.Write(cardDeck);
            }
        }
    }
}
