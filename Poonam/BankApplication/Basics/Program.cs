using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main12(string[] args)
        {
            StringBuilder sb = new StringBuilder("HelloWorld");
            Console.WriteLine(sb);
            sb.Append("India");
            Console.WriteLine(sb);
            sb.AppendLine("Hello");
            Console.WriteLine(sb);
            sb.Insert(3,"xyz");
            Console.WriteLine(sb);
            sb.Replace("hello", "hi");
            Console.WriteLine(sb);
            sb.Remove(5,10);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
