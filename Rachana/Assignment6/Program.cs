using System;

namespace Assignment6
{
    class Swap
    {
        public   void swap_Num(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Value of a & b in swap function\t{0} \t{1}", a, b);

        }

        public  void swap_Num( ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Value of a & b in swap function\t{0}\t{1}", a, b);
        }

        public  void swap_element(out  int a, out int b)
        {
            a = 50;
            b = 60;
            Console.WriteLine("Value of a & b before swap in swap function\t{0}\t{1}", a, b);
            int temp = a;
            a= b;
            b = temp;
            Console.WriteLine("Value of a & b in swap function \t\t{0} \t{1}", a, b);
        }
    }

    class Program
    { 
    
        static void Main(string[] args)
        {
            Swap s = new Swap();
            Console.WriteLine("Enter the values of a and b");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCall by Value");
            Console.WriteLine("Value of a & b before swap\t{0}\t{1}",a1,b1);
            s.swap_Num(a1, b1);
            Console.WriteLine("Value of a & b after swap\t{0}\t{1}", a1, b1);

            Console.WriteLine("\nCall by Reference");
            Console.WriteLine("Value of a & b before swap\t{0}\t{1}", a1, b1);
            s.swap_Num(ref a1, ref b1);
            Console.WriteLine("Value of a & b after swap\t{0}\t{1}", a1, b1);

            Console.WriteLine("\nCall with out parameter");
            Console.WriteLine("Value of a & b before swap\t{0}\t{1}", a1, b1);
            s.swap_element(out a1, out b1);
            Console.WriteLine("Value of a & b after swap\t{0}\t{1}", a1, b1);


        }
    }
}
