using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Operations
    {
        public void Add(int a, int b)
        {
             Console.WriteLine(a + b);
            
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine( a - b);
        }

        public void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }

    class UserDefinedExceptions : Exception
    {
        public UserDefinedExceptions(string message) : base(message)
        {

        }
    }
}
