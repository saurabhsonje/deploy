using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExceptionHandling
{
    class Operation
    {
        public int add(int number1, int number2)
        {
            return number1 + number2;
        }


        public int sub(int number1, int number2)
        {
            return number1-number2;
        }

        public int div(int number1, int number2)
        {
            return number1/number2;
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
