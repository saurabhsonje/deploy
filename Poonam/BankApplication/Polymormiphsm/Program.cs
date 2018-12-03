using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymormiphsm
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.eat();
            int[][] array = new int[2][];
            array[0] = new int[] { 1,2,3};
            array[1] = new int[] {4,5,6};
            Console.WriteLine(array[1][2]);
            Console.ReadKey();
        }
    }
}
