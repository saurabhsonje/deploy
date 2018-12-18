using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Operations
    {
        public delegate void DoOperation(int x,int y); // step 1. define a delegate
        // it is not a function. delegate is a reference type datatype;
        // hence wrote DoOperation and not doOperation

        DoOperation doOperation; // step 2 create a delegate Object

        public  DoOperation GetOperationType(int choice)
        {
            switch (choice)
            {
                case 1:
                    doOperation = Add;  // step 3: assign a method pointer to the delegate object
                    break;
                case 2:
                    doOperation = Sub;
                    break;
            }
            return doOperation;
        }

        private  void Add(int x, int y)
        {
            Console.WriteLine ($" Sum :{x + y}");
        }

        private  void Sub(int x, int y)
        {
            Console.WriteLine($" Sum :{x - y}");
        }
    }
}
