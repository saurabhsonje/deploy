using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignments
{

    class Calculation
    {
       

        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
           
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
