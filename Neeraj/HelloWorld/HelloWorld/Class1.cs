using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Class1
    {
        public void check()
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
           DateTime date = DateTime.Now;
            Console.WriteLine($"My name is {name} and the date is {date}");
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey(true);
        }

    }
}
