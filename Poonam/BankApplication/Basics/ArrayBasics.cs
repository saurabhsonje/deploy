using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class ArrayBasics
    {
        static void Main(string []args)
        {
            int[] a = { 10,20,30,40};
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
