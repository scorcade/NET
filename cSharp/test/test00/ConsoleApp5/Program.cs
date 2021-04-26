using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> func1 = (double a, double b) => { return a + b; };
            var result = func1(100.1, 200.1);
            
            Console.WriteLine(result);
        }
        enum Leve { 
            big,
            min,
            max,
        }

        class Person { 
            
        }
    }
}
