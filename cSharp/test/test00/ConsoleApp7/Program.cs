using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 30;
            int max1;
            int min1;

            Compare(num1,num2,out max1,out min1);
            Console.WriteLine(max1);
            Console.WriteLine("\n");
            Console.WriteLine(min1);

            // Console.WriteLine("Hello World!");
        }

        static void Compare(int number1,int number2,out int max,out int min) {

            if (number1 > number2)
            {
                max = number1;
                min = number2;
            }
            else {
                max = number2;
                min = number1;
            }
        }
    }
}
