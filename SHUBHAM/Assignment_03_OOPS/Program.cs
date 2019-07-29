using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{


    class Program
    {


        public readonly static string EXIT = "Enter 0 for Exit";
        public readonly static string ENTER_CUSTOMER_DETAILS = "Enter 1 For Entering Customer Details";
        public readonly static string DISPLAY_CUSTOMER_DETAILS = "Enter 2 For Displaying Customer Details";
        public readonly static string SEARCH_BY_NAME = "Enter 3 For Searching Customer By Name";
        public readonly static string SEARCH_BY_EMAIL = "Enter 4 For Searching Customer By Email";
        public readonly static string BANK_DETAILS = "Enter 5 For Bank Customer INFORMATION ";
        public readonly static string PRINTING_EXIT = "Exit";
        public readonly static string BANK_NAME = "Enter the Bank Name";
        public readonly static string BANK_ID = "Enter the Bank ID";



        static void Main(string[] args)
        {
             Initialization();
        }

        private static void Initialization()
        {

           
            List<Bank> banks = new List<Bank>();
            List<Customer> customers = new List<Customer>();
            Int16 choice = 0;

            do
            {
                Console.WriteLine(EXIT);
                Console.WriteLine(ENTER_CUSTOMER_DETAILS);
                Console.WriteLine(DISPLAY_CUSTOMER_DETAILS);
                Console.WriteLine(SEARCH_BY_NAME);
                Console.WriteLine(SEARCH_BY_EMAIL);
                Console.WriteLine(BANK_DETAILS);

                choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Bank b = new Bank();
                        Console.WriteLine(BANK_ID);
                        b.BankId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(BANK_NAME);
                        b.BankName = Console.ReadLine();
                        Customer customer = CustomerUtils.CustomerDetails();
                        b.Customers.Add(customer);
                        banks.Add(b);
                        customers.Add(customer);
                      
                        break;

                    case 2:
                             CustomerUtils.DisplayCustomerDetailList(customers);
                             break;

                    case 3:
                            CustomerUtils. SearchCustomerByName(customers);
                            break;


                    case 4:
                             CustomerUtils. SearchCustomerByEmail(customers);
                            break;


                    case 5:
                             BankUtils.BankInfo(banks);
                             break;

                   default:
                        Console.WriteLine(PRINTING_EXIT);
                        System.Environment.Exit(0);
                        break;
                }
            } while (choice != 0);

        }

    }
}
