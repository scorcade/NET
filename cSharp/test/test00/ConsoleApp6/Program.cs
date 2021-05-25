using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 45, 27, 55, 3, 6, 2, 100, 90 };
            int length = num.Length;
            int item = 0;

            for (int j = 0; j < length-1; j++)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        item = num[i + 1];
                        num[i + 1] = num[i];
                        num[i] = item;
                    }
                }
            }



            foreach (int items in num)
            {
                Console.WriteLine($"{items}\n");
            }

            //int[] num = new int[] { 1, 2, 3, 4, 5 };

            //foreach (int item in num)
            //{
            //    Console.WriteLine($"{item}\n");
            //}
;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(Mydate.Mon);

        }

        enum Mydate
        {
            Mon=0,
            Tue=1,
            Wed=2,
        }
    }
}
