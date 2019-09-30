using System;

namespace Assignment3
{
    class Program
    {
        // static variable 
        static int s;

        // non-static variable 
        int ns;

        // declaration of 
        // static constructor 
        static Program()
        {
            Console.WriteLine("Static constructor");
        }

        // declaration of 
        // non-static constructor 
        Program()
        {
            Console.WriteLine("Non-Static constructor");
        }

        // Main Method 
        static void Main(string[] args)
        {

            // static fields can 
            // be accessed directly 
            Console.WriteLine("Value of s is: " + s);

            // calling non-static constructor 
            Program obj1 = new Program();

            // printing the value 
            // of non-static field 
            Console.WriteLine("Value of ns is: " + obj1.ns);
        }
    }
}
