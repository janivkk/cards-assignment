using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace A3FINAL
{
    //Polymorphism 
    class SaveTheScore : Game
    {
        //Save the first round
        public string Save(string a)
        {
            a = tillTheEnd.ToString();
            File.WriteAllText("score_cardgame.txt", a);
            return a;
        }

        //Save any round after the first
        public string Save(string a, string b)
        {
            a = tillTheEnd.ToString();
            Console.Write("Round? : ");
            b = Console.ReadLine();
            File.WriteAllText("score_cardgame.txt", a + b);
            return a + b;
        }
    }
}
