using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> namesList = new List<string>
            {
                "neeraj","abcd","joshi"
            };

           IEnumerable<string> empQueryList= namesList.Where(name => name.EndsWith("i"));

            //List<string> list = empQueryList.ToList();

            foreach (string emp in empQueryList)
            {
                Console.WriteLine($"{emp }");
            }

          //  Console.WriteLine($"{ empQueryList}");
           // Console.WriteLine($"{ list}");

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
