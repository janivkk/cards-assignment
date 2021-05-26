using System;

namespace A3FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Game g = new Game();
            g.Gameplay();
            Test t = new Test();
            t.Testing();*/

            DeckEnum d = new DeckEnum();
            Console.Write($"P1: {d.Hand()}");
            Console.ReadKey();
        }
    }
}
