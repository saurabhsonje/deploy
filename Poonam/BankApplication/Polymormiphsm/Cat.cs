using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymormiphsm
{
    class  Cat:Animal
    {
        public override void eat()
        {
            Console.WriteLine("Cat Eating Grass");
        }
    }
}
