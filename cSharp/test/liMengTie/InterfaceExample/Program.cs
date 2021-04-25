using System;
using System.Collections;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());
            double
                int


            //var user = new PhoneUser(new EricssonPhone()); -------------------
            //user.UsePhone();



            //int[] nums1 = new int[] { 1, 2, 3, 4, 5 };   -------------------------------
            //ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

            //Console.WriteLine(Sum(nums1));
            //Console.WriteLine(Avg(nums1));
            //Console.WriteLine(Sum(nums2));
            //Console.WriteLine(Avg(nums2));
            ////Console.WriteLine("Hello World!");

            //static int Sum(IEnumerable nums)
            //{
            //    int sum = 0;
            //    foreach (var n in nums)
            //    {
            //        sum += (int)n;
            //    }
            //    return sum;
            //}
            //static double Avg(IEnumerable nums)
            //{
            //    int sum = 0;double count = 0;
            //    foreach (var n in nums)
            //    {
            //        sum += (int)n;
            //        count++;
            //    }
            //    return sum / count;
            //}
        }
    }

   public interface IPowerSupply
    {
        int GetPower();
    }
     public class PowerSupply:IPowerSupply
    {
        public int GetPower()
        {
            return 110;
        }
    }

   public class DeskFan
    {
        private IPowerSupply _PowerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            _PowerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _PowerSupply.GetPower();
            if (power<=0)
            {
                return "Won't work.";
            } else if (power <= 100)
            {
                return "Slow";
            }else if (power <= 200)
            {
                return "Work fine";
            }else
            {
                return "Warning!";
            }
        }
    }
    //class PhoneUser
    //{
    //    public PhoneUser(IPhone phone)
    //    {
    //        _phone = phone;
    //    }
    //    private IPhone _phone;

    //    public void UsePhone()
    //    {
    //        _phone.Dail();   
    //        _phone.PickUp();   
    //        _phone.Send();   
    //        _phone.Receive();
    //    }


    //}

    //interface IPhone
    //{
    //    void Dail();
    //    void PickUp();
    //    void Send();
    //    void Receive();
    //}
    //class NokiaPhone : IPhone
    //{
    //    public void Dail()
    //    {
    //        Console.WriteLine("Nokia calling...");
    //    }

    //    public void PickUp()
    //    {
    //        Console.WriteLine("Hello! This is Tim!");
    //    }

    //    public void Receive()
    //    {
    //        Console.WriteLine("Nokia message ring...");
    //    }

    //    public void Send()
    //    {
    //        Console.WriteLine("Hello!");
    //    }
    //}
    //class EricssonPhone : IPhone
    //{
    //    public void Dail()
    //    {
    //        Console.WriteLine("Ericsson calling...");
    //    }

    //    public void PickUp()
    //    {
    //        Console.WriteLine("Hi! This's Tim!");
    //    }

    //    public void Receive()
    //    {
    //        Console.WriteLine("Ericsson message ring...");
    //    }

    //    public void Send()
    //    {
    //        Console.WriteLine("Good evening!");
    //    }
    //}


}
