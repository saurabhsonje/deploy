using System;
using System.Text;

namespace ReplaceStringSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("this is text", 50);
            
            Console.WriteLine("Original text : "+ sb);
            sb.Replace("this is", "replacement");
            Console.WriteLine("replaced Text: " + sb);

            StringBuilder sb2 = new StringBuilder("C# program");
            
            sb2.Append(" of Microsoft");
            Console.WriteLine(sb2);
            
            sb2.Remove(10, 3);
            Console.WriteLine(sb2);
        }
    }
}
