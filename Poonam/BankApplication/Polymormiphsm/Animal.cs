using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymormiphsm
{
    class Animal
    {
        public  virtual void eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
