//#define WIN
using System;



namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int \u005file = 300;
            Console.WriteLine(\u005file);

            #region
#if WIN
//#warning "eeeeeeee"
            Console.WriteLine("yes");
#endif
            #endregion
        }
    }
}