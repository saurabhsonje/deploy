using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExceptionHandling
{
    class Operation
    {
        public int add(int a, int b)
        {
            return a + b;
        }


        public int sub(int a, int b)
        {
            return a - b;
        }
    }

    class UserDefinedException : Exception
    {
        public UserDefinedException(string msg) : base(msg)
        {
        //    Specify which base -class constructor should be called when creating instances of the derived class.
        }
    }
}
