using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing
             int num = 10;
             object obj = num;



            Console.WriteLine("Value - type value of num is : {0}", num);
            Console.WriteLine("Object - type value of obj is : {0}", obj);

            // Console.ReadLine();




            // unboxing 
            int i = (int)obj;

            // Display result 
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
            Console.ReadLine();
        }

    }
}
