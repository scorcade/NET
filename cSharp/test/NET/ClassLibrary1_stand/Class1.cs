using System;
using System.IO; 

namespace ClassLibrary1_stand
{
    public  class Class1
    {
        public static void Test()
        {
            Console.WriteLine(typeof(FileStream).Assembly.Location );
            Console.WriteLine(typeof(Class1).Assembly.Location );
        }
    }
}
                                       