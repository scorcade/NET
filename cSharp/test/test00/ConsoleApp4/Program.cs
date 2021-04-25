using System;
using System.Reflection;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //using System.Reflection;
            Console.WriteLine("Hello World!");
            Assembly assembly = Assembly.Load(???);
            Type type = assembly.GetType(????);
            var dll = Activator.CreateInstance(type);
            MethodInfo
        }
    }
}
