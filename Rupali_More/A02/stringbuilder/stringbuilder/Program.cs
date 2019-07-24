using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            //Append method
            sb.Append(" I am Rupali.");
            Console.WriteLine(sb);
            //appendFormat
            StringBuilder sb1 = new StringBuilder("Hello");
            int amount = 100;
             sb1.AppendFormat(".net book price is:"+ amount.ToString());
            Console.WriteLine(sb1);
            //insert
            sb1.Insert(5," everyone ");
            Console.WriteLine(sb1);

            //remove
            sb1.Remove(2,5);
            Console.WriteLine(sb1);
         
            //replace
            
            sb1.Insert(1,"ello ");
            Console.WriteLine(sb1);
            sb1.Replace(".net","java");
            Console.WriteLine(sb1);

            //copyto
            char[] str = new char[10];
            sb1.CopyTo(6, str, 0, 8);
            Console.WriteLine(str);

            //maxcapacity/lenght/get type
            Console.WriteLine(sb1.MaxCapacity);
            Console.WriteLine(sb1.Length);
            Console.WriteLine(sb1.GetType());

            //clear
            sb1.Clear();
            Console.WriteLine(sb1);
            Console.ReadLine();
        }
    }
}
