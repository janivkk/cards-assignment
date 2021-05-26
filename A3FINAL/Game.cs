using System;
using System.Collections.Generic;
using System.Text;

namespace A3FINAL
{
    class Game : DeckEnum
    {
        private int tillTheEnd = 21;

        public override void WelcomeMessage()
        {
            //base.WelcomeMessage(); //Unchanged output from DeckEnum class
            Console.Write("Playing now...");
        }

        public void Play()
        {
            Console.Write("\n");
            WelcomeMessage();

            DeckEnum d = new DeckEnum();
            Console.Write("\n\nShuffling the deck...");
            Console.Write("\n\nP1 (you): \n");
            d.Hand();
            Console.Write("\n\nP2 (computer): \n");
            d.Hand();

            try
            {
                
            }
            catch (ArgumentException)
            {

            }

            while ()
            {
                /* Console.Write("\n\nChoose what card to play: ");
                   string playerCard = Console.ReadLine();
                 * 
                 * if (playerCard > computerCard)
                 
                 else if (playerCard < computerCard)
                
                 else if (playerCard == computerCard) give point
                
                 else, throw exception*/
            }

            Console.ReadKey();
        }
    }
}
