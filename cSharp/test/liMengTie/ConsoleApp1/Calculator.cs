namespace ConsoleApp1
{
    internal class Calculator
    {
        //public  void PrintXTto1(int x)
        //{
        //    for (int i = x; i > 0; i--)
        //    {
        //        System.Console.WriteLine(i);

        //    }




        //public void PrintXTto1(int x)
        //{
        //    if (x == 1)
        //    {
        //        System.Console.WriteLine();
        //    }
        //    else
        //    {
        //        System.Console.WriteLine(x);
        //        PrintXTto1(x - 1);
        //    }
        //}




        //  public int SumForm1ToX(int x)
        //{
        //    int result = 0;
        //    for (int i = 0; i < x+1; i++)
        //    {
        //        result = result + i;
        //    }

        //    return result;
        //}  




        public int SumForm1ToX(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                int result = x + SumForm1ToX(x - 1);
                return result;
            }
        }




        //public int SumForm1ToX(int x)        //SumForm1ToX
        //{
        //    return (1 + x) * x / 2;
        //}

    }

    
}