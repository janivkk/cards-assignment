using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace A3FINAL
{
    class Game
    {
        private int score;
        protected int round;

        //Constructor where the game actually happens
        public void Gameplay()
        {
            try
            {
                while (round == 5)
                {
                    Deck d = new Deck();
                    d.Hand();

                    //Exception if not enough space & writes the score to a file
                    try
                    {
                        using (StreamWriter wt = new StreamWriter("score.txt"))
                        {
                            wt.WriteLine("Score: " + score);
                        }
                    }
                    catch (IOException)
                    {
                        Console.Write("Not enough space on your computer");
                    }
                    round++;
                }
            }
            catch (Exception e)
            {
                Console.Write("An error occurred: ", e);
                throw;
            }
        }
    }
}
