using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           Programmer emp = new Programmer(1, "xyz", 8000, 2000);
           
            double balance=emp.calSal();
            Console.WriteLine(balance);
            Console.ReadLine();
        }
    }
}
