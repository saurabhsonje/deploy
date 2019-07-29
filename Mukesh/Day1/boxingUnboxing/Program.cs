using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int myValue = 20;

            //Boxing
            object boxed = myValue;

            //Unboxing
            int unboxed = (int)boxed;

            Console.ReadKey();
        }
       
    }
}
