using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            Stopwatch chronometer = new Stopwatch();

            chronometer.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i.ToString());
            }

            //for (int i = 0; i < 100000; i++)
            //{
            //    str += i.ToString();
            //}
            chronometer.Stop();
            Console.WriteLine(chronometer.ElapsedMilliseconds);


        }
    }
}
