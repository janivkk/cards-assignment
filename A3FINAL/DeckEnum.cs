using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    class DeckEnum : TimeComplexity
    {
        //Class list
        public readonly List<CardEnum> DeckListEnum = new List<CardEnum>();

        //Constructor, populating the deck with cards and its suits 
        public DeckEnum()
        {
            foreach (eSuit suit in Enum.GetValues(typeof(eSuit)))
            {
                foreach (eCard card in Enum.GetValues(typeof(eCard)))
                {
                    DeckListEnum.Add(new CardEnum(card, suit));
                }
            }
        }

        //Lambda expression to count no. of cards in the list then assign it to a int variable
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
                timeThatTakesToGetThrough++;
            }
        }

        //Sorting the deck of cards
        public void Sort() => DeckListEnum.Sort();
        public void Sort(IComparer<CardEnum> com) => DeckListEnum.Sort(com);

        //Polymorphism (many forms of an method/object)
        public virtual void WelcomeMessage()
        {
            Console.Write("Welcome to the card game.");
        }

        //Hand for a player
        //-- need to give a hand of 10 to player
        public void Hand()
        {
            //If there's an issue with range, throw an exception
            try
            {
                Shuffle();
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(DeckListEnum[i] + " | ");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Write("out of range!");
                throw;
            }

        }

        public void HandT()
        {
            /*Console.Write("\nDeck of cards: ")
            HandTen();
            Console.Write("\n")*/
            for (int j = 0; j < 2; j++)
            {
                Console.Write(DeckListEnum[j] + " | ");
            }
        }
    }
}
