using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Calculation : CalAdd, CalDiv, CalMul, CalSub
    {

       public int add(int a, int b)
        {
            return a + b;
        }

        public int div(int a, int b)
        {

            return a / b;
        }

        public int mul(int a, int b)
        {
            return a*b;
        }
        public int sub(int a, int b)
        {
            return a-b;
        }
    }
}
