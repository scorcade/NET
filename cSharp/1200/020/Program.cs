using System;

namespace _020
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            string yyy;

            Console.WriteLine("----");
            yyy = Console.ReadLine();
            year = Convert.ToInt32(yyy);
             //bool year = xxx is int;

            if (DateTime.IsLeapYear(yyy))
            {
                Console.WriteLine("yyyyyy");
            }
            else
            { Console.WriteLine("nnnn"); }


            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine("yyyyyy");
            //}
            //else
            //{ Console.WriteLine("nnnn"); }
        }
    }
}
