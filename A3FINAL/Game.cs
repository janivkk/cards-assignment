using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    class Game : DeckEnum
    {
        public int tillTheEnd = 21;

        //Inherited from DeckEnum to be overriden
        public override void WelcomeMessage()
        {
            //base.WelcomeMessage(); //Unchanged output from DeckEnum class
            Console.Write("Playing now...");
        }

        public void Play()
        {
            //Try-catch exception
            try
            {
                Console.Write("\n");
                WelcomeMessage();

                DeckEnum d = new DeckEnum();
                Console.Write("\n\nShuffling the deck...");
                Console.Write("\n\nP1 (you): \n");
                d.Hand();
                Console.Write("\n\nP2 (computer): \n");
                d.Hand();

                //Human player can choose what card to choose
                Console.Write("\n\nCard 1: ");
                string playerCardChoice = Console.ReadLine();
                eCard playerCard = (eCard)Enum.Parse(typeof(eCard), playerCardChoice);
                //
                Console.Write("\nCard 2: ");
                string playerCardChoiceTwo = Console.ReadLine();
                eCard playerCardTwo = (eCard)Enum.Parse(typeof(eCard), playerCardChoiceTwo);
                
                Console.Write($"Cards: {playerCard} | {playerCardTwo} , Total: {Enum.GetValues(typeof(eCard))}");
            }

            catch (Exception)
            //If exception(any) is thrown, terminate the program to avoid
            //potential crash...
            {
                Console.Write("Error, restart...");
                throw;
            }

            Console.ReadKey();
        }
    }
}
