using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    class Program
    {
        static int choice , answer;

        static void Main(string[] args)
        {
            do
            {
                Customer cust = new Customer();
                Console.WriteLine("Welcome To Customer Management");
                Console.WriteLine("The facilities are");
                Console.WriteLine("1. New User");
                Console.WriteLine("2. Registered User");
            
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Welcome New User");
                            Enquiry eq = new Enquiry();
                            eq.getDiscount(150.5);
                            break;
                        }

                    case 2:
                        {
                            do
                            {
                                Console.WriteLine("Welcome Registered User");
                                Console.WriteLine("Enter your Customer Type:");
                                Console.WriteLine("1.Silver Customer");
                                Console.WriteLine("2.Gold Customer");
                                Console.WriteLine("Enter your choice");
                                choice = int.Parse(Console.ReadLine());
                                switch (choice)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Welcome Silver Customer");
                                            SilverCustomer sc = new SilverCustomer();
                                            sc.getDiscount(120.35);
                                            break;
                                        }

                                    case 2:
                                        {
                                            Console.WriteLine("Welcome Gold Customer");
                                            GoldCustomer gc = new GoldCustomer();
                                            gc.getDiscount(120.35);
                                            break;
                                        }
                                }
                                Console.WriteLine("Do you want to continue");
                                answer = int.Parse(Console.ReadLine());
                            }
                            while (answer == 1);

                       
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue");
                answer = int.Parse(Console.ReadLine());
            }
            while (answer == 1);
            Console.WriteLine("Thank you Customer");
            Console.ReadLine();


        }
    }
}
