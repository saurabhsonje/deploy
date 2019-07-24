using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "678"; 
            Int16 number = Convert.ToInt16(s); //Unboxing
            Console.WriteLine("Result of UnBoxing(Reference to Value type)" + " " + number);


            int k = 10;
            object o = k;  //   (Boxing :- Value Type To Reference Type)

            int j = (int)o;  // (Unboxing:- Reference Type To Value Type )

            Console.WriteLine(" Printing Object " + " " + Convert.ToString(o));
            Console.WriteLine("Printing j " + " " + j);


        }
    }
}
