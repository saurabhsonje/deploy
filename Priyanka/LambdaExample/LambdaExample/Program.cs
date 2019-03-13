using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 40, 50, 10, 20, 30, 70, 100 };
            int display = a.Select(x =>x).Sum();
            Console.WriteLine("Addition using Lambda Expression: " + display);
           

            var sort = a.OrderBy(x => x);
            Console.WriteLine("Sorting using Lambda Expression: ");
            foreach (var s in sort)
            {
                Console.WriteLine(s);
                
            }
            Console.ReadLine();
        }
    }
}
