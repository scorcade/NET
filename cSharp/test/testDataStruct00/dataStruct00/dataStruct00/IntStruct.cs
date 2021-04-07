using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStruct00
{
    class IntStruct
    {
        static void Main()
        {
            int num;
            string snum;

            Console.Write("please Enter a number: ");
            snum = Console.ReadLine();
            num = Int32.Parse(snum);

            Console.WriteLine(num);

        }
    }
}
