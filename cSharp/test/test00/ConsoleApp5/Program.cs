using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> func1 = (double a, double b) => { return a + b; };
            var result = func1(100.1, 200.1);

            Person person = new Person();
            //person.Leve = Level.big;
            person.Leve = Level.big;
            
            //Console.WriteLine(result);

        }
        enum Level { 
            big,
            min,
            max,
        }

        class Person { 
            public int id { get; set; }
            public string Name { get; set; }
            public Level Leve { get; set; }

        }
    }
}
