using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ConsoleApp4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Calculator.Div(3,0);
            Console.WriteLine(result);
        }
    }
}
