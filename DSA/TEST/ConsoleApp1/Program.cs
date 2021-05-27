using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int aa = 103;
            int bb = 210;
            int cc;

            cc = gcd(aa, bb);

            Console.WriteLine("Hello World!");
            Console.WriteLine(cc);
        }
        public static int gcd(int p, int q) {
            if (q==0)
            {
                return p;
            }
            else
            {
                int r = p % q;
                return gcd(q, r);
            }
        }

    }
}
