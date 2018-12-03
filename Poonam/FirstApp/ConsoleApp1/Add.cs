using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1

{
    class Add
    {
        static void Main12(string[] args)
        {
         
            Console.WriteLine("Enter value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            int b = Int32.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("ADDITITON IS " + c);
            Console.ReadLine();
        }
    }
}
