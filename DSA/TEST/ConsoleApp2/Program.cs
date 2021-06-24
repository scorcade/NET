using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Hello World!");
        }

        public int[] SingleNumbers(int[] nums)
        {
            int ret = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                ret ^= nums[i];
            }

            int m = 0;
            int xxx = ret & (1 << m);
            while (m < 32)
            {
                if (Convert.ToBoolean(ret & (1 << m))) 
                    break;
                else
                    ++m;
            }

            int x1 = 0;
            int x2 = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (Convert.ToBoolean(nums[i] & (1 << m))) 
                {
                    x1 ^= nums[i];
                }
                else
                {
                    x2 ^= nums[i];
                }
            }

            int[] myArray = new int[2];
            myArray[0] = x1;
            myArray[1] = x2;

            return myArray;

        }






    }



}
