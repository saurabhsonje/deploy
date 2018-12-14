using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int choice = 0;
            Console.WriteLine("1. Add 2.Subtract 3.Divide 4.Multiply");
            choice=Convert.ToInt32 (Console.ReadLine());

            Operations operations = new Operations();
            operations.GetOperationType(choice).Invoke(3,5);


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
