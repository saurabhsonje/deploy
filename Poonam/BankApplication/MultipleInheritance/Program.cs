using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b;
           int ch;
            char choice;
            Console.WriteLine("Enter Two Numbers");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            do
            {
               
                Console.WriteLine("Enter Your Choice");
                ch = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");

                Calculation cal = new Calculation();
                switch (ch)
                {
                    case 1:
                int resultAdd = cal.add(a, b);
                Console.WriteLine("Addition is " + resultAdd);
                        break;
                    case 2:
                int resultSub = cal.sub(a, b);
                Console.WriteLine("Subtraction is " + resultSub);
                        break;
                    case 3:
                int resultMul = cal.mul(a, b);
                Console.WriteLine("Multiplication is " + resultMul);
                        break;
                    case 4:
                int resultDiv = cal.div(a, b);
                Console.WriteLine("Division is " + resultDiv);
                        break;
            }
                Console.WriteLine("Do You Want To Continue");
               choice = Convert.ToChar(Console.ReadLine());
            } while (choice.Equals('Y')||choice.Equals('y'));

        }
    }
}
