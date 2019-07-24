using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 456;
            object o;       
            
            //boxing integer to object
            o = i;

            //changing value of i
            i = 234;
            Console.WriteLine("Value of object o in boxing is:{0}",o);
            Console.WriteLine("Value of integer i in boxing is:{0}", i);


            //UnBoxing object to integer
            o = 564;
            i = (int) o;
            Console.WriteLine("Value of object o in unboxing is:{0}", o);
            Console.WriteLine("Value of integer i in unboxing is:{0}", i);
            

            //using string unboxing 
            string str = "123";
            i = int.Parse(str);
            Console.WriteLine("Value of i in unboxing:{0}",i);

            //using string boxing 
            i = 123;
            str= i.ToString();
            Console.WriteLine("Value of string in boxing:{0}", str);

            Console.ReadKey();
                                
        }
    }
}
