using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    class Deck
    {
        //Parameters
        protected internal const int numOfCards = 52; //Internal => in Deck class only & derived from
        private Card[] deckCards; //Array of Cards
        private int currCard; //Current card being played
        public Random ranCard;

        //Constructor
        public Deck()
        {
            //Cards
            string[] faceCards = {"A", "2", "3", "4", "5", "6", "7", "8", "9",
            "10", "11", "J", "Q", "K"};
            //Suits
            string[] suitCards = { "H", "C", "D", "S" };
            //hearts, clubs, diamonds, spades
            //Values for cards

            deckCards = new Card[numOfCards]; //Creating a new deck of cards

            for (int i = 0; i < deckCards.Length; i++) //Populating the deck
            {
                deckCards[i] = new Card(faceCards[i % 11], suitCards[i / 13]);
            }
        }

        //Methods: shuffling and dealing
        public void Shuffle()
        {
            //Sorting Algorithm
            currCard = 0;
            ranCard = new Random();

            for (int i = 0; i < deckCards.Length; i++)
            {
                int j = ranCard.Next(numOfCards);
                Card t = deckCards[i];
                deckCards[i] = deckCards[j];
                deckCards[j] = t;
            }

        }

        public Card Deal()
        {
            if (currCard < deckCards.Length)
            {
                return deckCards[currCard++];
            }
            else
            {
                return null;
            }
        }

        //Deals the hand to a player
        public void Hand()
        {
            Deck d = new Deck(); d.Shuffle();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0, 19}", d.Deal());
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
