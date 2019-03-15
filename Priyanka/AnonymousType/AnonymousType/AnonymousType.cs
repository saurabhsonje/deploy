using System;

namespace AnonymousType
{
    class AnonymousType
    {
        static void Main(string[] args)
        {

            var myAnonymousType = new{ name = "Priyanka"};

            Display(myAnonymousType);
        }

        static void Display(dynamic param)
        {
            Console.WriteLine(param.name);
            Console.ReadLine();
        }
    }
}
