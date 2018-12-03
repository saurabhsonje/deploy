using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Basics
    {
        int x;
        int y;
        static int z;
        static Basics()
        {
            z = 10;
        }

        public Basics(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        static void Main17(string[] args)
        {
            Basics bs = new Basics(10,20);
            Console.WriteLine(bs.x);
            Console.WriteLine(bs.y);
            Console.WriteLine(Basics.z);
            Console.ReadLine();
        }
    }
}
