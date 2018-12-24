using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Delegate
    {
        public delegate void Print(int num);

        static void Main1(string[] args)
        {
            Print printDel = PrintNumber;
            printDel(1000);
            printDel(500);
            printDel = PrintMoney;
            printDel(1000);
            printDel(500);
            Console.ReadLine();
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}",num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);

        }
        
    }
}
