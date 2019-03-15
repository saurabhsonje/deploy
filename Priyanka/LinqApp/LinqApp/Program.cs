using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqApp
{
    class Program
    {
        public static void Main()
        {
            
            List<string> list = new List<string>() { "Priyanka", "Shreya", "Poonam","Roma"};

           
            var result = from s in list
                         where s.Count() > 5
                         select s;

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
