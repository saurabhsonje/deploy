using System;
using System.Text;

namespace Assignment3
{
    class Program
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder("Hello World ",50);
            Console.WriteLine(s);
            Console.WriteLine("Enter the string");
            string str = Convert.ToString(Console.ReadLine());
            s.Replace("World", str);
            Console.WriteLine(s);
        }
    }
}


