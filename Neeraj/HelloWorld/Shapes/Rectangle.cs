using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape,Drawable,Printable
    {

        public void draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public void print()
        {
            Console.WriteLine("Printing Triangle");
        }
    }
}
