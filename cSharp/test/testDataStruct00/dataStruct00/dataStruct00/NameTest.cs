using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStruct00
{
    class NameTest
    {
        static void Main()
        {
            string fullNmae, inits;

            Name myNmae = new Name("Michael", "Mason", "McMillan");
            fullNmae = myNmae.ToString();
            inits = myNmae.Initials();

            //Console.WriteLine(fullNmae);
            //Console.WriteLine(inits);

            Console.WriteLine($"My name is {fullNmae}.");
            Console.WriteLine($"My initials are {inits}.");

        }

        public struct Name
        {
            private string _fname, _mname, _lname;
            public Name(string first, string middle, string last)
            {
                _fname = first;
                _mname = middle;
                _lname = last;
            }
            public string firstName
            {
                get { return _fname; }
                set { firstName = value; }
            }

            public string middleName
            {
                get { return _mname; }
                set { middleName = value; }
            }

            public string lastName
            {
                get { return _lname; }
                set { lastName = value; }
            }

            public override string ToString()
            {
                return (String.Format("{0} {1} {2}", _fname, _mname, _lname));
            }
            public string Initials()
            {
                return (String.Format("{0}{1}{2}", _fname.Substring(0, 1), _mname.Substring(0, 1), _lname.Substring(0, 1)));

            }
        }
    }
}
