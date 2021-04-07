using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                char aaa = 'A';
                aaa = Console.ReadKey().KeyChar;

                char inputLetter = aaa;

                int yyy = ((inputLetter + 20) % 58);
                int nnn = -23 % 1;
                //int nnn = 64 + yyy + 6 * (96 - yyy);
                //int nnn = character % 3;

                char xxx = (char)(64 + ((inputLetter + 20) % 58) + 6 * (90 / inputLetter));
                Console.WriteLine("\n");
                Console.WriteLine(xxx);
                // Console.WriteLine(nnn);
                //Console.WriteLine(yyy);
                Console.WriteLine("----");
            } while (true);

            
        }
    }
}
