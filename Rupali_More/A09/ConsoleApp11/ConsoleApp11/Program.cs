using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Date = DateTime.Now;
            Console.WriteLine("current datetime format :- {0}",Date);
            string result = Date.dateformat1(); 
            Console.WriteLine("\nAfter changing format:- {0}",result);
            Console.ReadLine();
                      
        }
    }
}
