using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Customer
    {
        public static int choice;
        public static int answer;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Customer");
            Bank b1 = new Bank(1, "Atul", 10500.5f);
            Bank b2 = new Bank(2, "Shikha", 4500.75f);
            Bank b3 = new Bank(3, "Karan", 9500f);
            do
            {
                Console.WriteLine("Enter your Choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Displaying Customer Details");
                        b1.Display();
                        b2.Display();
                        b3.Display();
                        break;

                    case 2:
                        Console.WriteLine("Performing Deposit operation");
                        b2.Deposit();
                        break;

                    case 3:
                        Console.WriteLine("Performing Withdraw operation");
                        b1.Withdraw();
                        break;

                    case 4:
                        Console.WriteLine("Sorry !! Wrong operation");
                        break;

                }
                Console.Write("Do you want to continue");
                answer = int.Parse(Console.ReadLine());

            }
            while (answer == 1);
            Console.WriteLine("Thank you Customer");
            Console.ReadLine();

        }
        

    }
}
