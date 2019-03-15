using System;

namespace DelegateApp
{
    class Program
    {
        public delegate void Print(int a,int b);

        static void Main(string[] args)
        {
          
            Print printDel = AddNumber;

            printDel(20,10);

             printDel = SubtractNumber;

            printDel(10, 20);

             printDel = MultiplyNumber;

            printDel(10, 20);
            Console.ReadLine();
            
        }

        public static void AddNumber(int a,int b)
        {
            Console.WriteLine("Addition: {0,-12:N0}", a+b);
        }
        public static void SubtractNumber(int a, int b)
        {
            Console.WriteLine("Addition: {0,-12:N0}", a - b);
        }
        public static void MultiplyNumber(int a, int b)
        {
            Console.WriteLine("Addition: {0,-12:N0}", a * b);
        }
      
    }
}
