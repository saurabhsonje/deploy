using System;
using System.Text;

namespace Assignment2
{
    class Program
    {
        public static void Main(String[] args)
        { 
        StringBuilder sb = new StringBuilder("Hello World!!", 50);
        sb.Replace("World", "C#");

        Console.WriteLine(sb);
        }
    }
}
