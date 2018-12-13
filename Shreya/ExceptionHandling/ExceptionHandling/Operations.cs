using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Operations
    {
        public int Add(int a, int b)
        {
             return a + b;
            
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    class UserDefinedExceptions : Exception
    {
        public UserDefinedExceptions(string message) : base(message)
        {

        }
    }
}
