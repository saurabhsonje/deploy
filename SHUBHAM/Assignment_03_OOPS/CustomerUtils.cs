using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{
    class CustomerUtils
    {
        public readonly static string ENTER_CHOICE = "Enter the Choice";
        public readonly static string CUSTOMER_ID = "Enter Id of the Customer";
        public readonly static string CUSTOMER_NAME = "Enter Name of the Customer";
        public readonly static string CUSTOMER_EMAIL = "Enter Email of the Customer";
        public readonly static string SAVING_ACCOUNT = "Enter 1 for Saving Account";
        public readonly static string CURRENT_ACCOUNT = "Enter 2 for Current Account";
        public readonly static string NO_RESULT_FOUND = "NO RESULT FOUND -------->";
        public readonly static string SEARCH_BY_NAME = "Enter The Customer Name You Want To Search";
        public readonly static string SEARCH_BY_EMAIL = "Enter The Customer Email You Want To Search";




        public static Customer CustomerDetails()
        {
            Int16 Choice = 0;
            Customer customer = new Customer();
            Console.WriteLine(CUSTOMER_ID);
            customer.CustomerId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(CUSTOMER_NAME);
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine(CUSTOMER_EMAIL);
            customer.CustomerEmail = Console.ReadLine();

            Console.WriteLine(SAVING_ACCOUNT);
            Console.WriteLine(CURRENT_ACCOUNT);
            Console.WriteLine(ENTER_CHOICE);
            Choice = Convert.ToInt16(Console.ReadLine());
            switch (Choice)
            {

                case 1:
                    SavingAccount savingAccount = new SavingAccount();
                    Console.WriteLine("Enter Account Number");
                    savingAccount.AccountNumber = Console.ReadLine();
                    savingAccount.AccountType = "Saving";
                    customer.Aaccount = savingAccount;
                    savingAccount.Deposit(customer, 500);
                    break;


                case 2:
                    CurrentAccount currentAccount = new CurrentAccount();
                    Console.WriteLine("Enter Account Number");
                    currentAccount.AccountNumber = Console.ReadLine();
                    currentAccount.AccountType = "Current";
                    customer.Aaccount = currentAccount;
                    currentAccount.Deposit(customer, 1000);
                    break;

                default:
                    Console.WriteLine("Enter valid Account Type");
                    break;
            }

            return customer;

        }

        public static void DisplayCustomerDetailList(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                DisplayCustomerDetail(customer);
            }
        }


        public static void DisplayCustomerDetail(Customer customer)
        {
            Console.WriteLine(customer.ToString());
            Console.WriteLine(customer.Aaccount.ToString());
            Console.WriteLine("<------------------------------------------------------------------------->");
        }


        public static void SearchCustomerByName(List<Customer> customers)
        {
            Console.WriteLine(SEARCH_BY_NAME);
            try
            {
                Customer customer = customers.Find(x => x.CustomerName == Console.ReadLine());
                DisplayCustomerDetail(customer);
                CustomerRelatedTransactions(customer);
            }
            catch (Exception)
            {
                Console.WriteLine(NO_RESULT_FOUND);
            }
        }

        public static void CustomerRelatedTransactions(Customer customer)
        {
            Int16 Choice = 0;
            SavingAccount savingAccount = null;
            CurrentAccount currentAccount = null;

            if (customer.Aaccount.AccountType.Equals("Saving"))
            {
                savingAccount = new SavingAccount();
            }
            else
            {
                currentAccount = new CurrentAccount();
            }


            do
            {

                Console.WriteLine("Enter 0 To EXIT FROM CUSTOMER RELATED OPERATIONS ");
                Console.WriteLine("Enter 1 To Deposit ");
                Console.WriteLine("Enter 2 To Withdrow ");
                Console.WriteLine("Enter 3 To Calculate Interest ");

                Console.WriteLine("Enter The Choice ");

                Choice = Convert.ToInt16(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Amount You Want To Deposit");
                        savingAccount.Deposit(customer, Convert.ToDouble(Console.ReadLine()));
                        DisplayCustomerDetail(customer);
                        break;


                    case 2:
                        Console.WriteLine("Enter the Amount You Want To WithDrow");
                        savingAccount.Withdrow(customer, Convert.ToDouble(Console.ReadLine()));
                        DisplayCustomerDetail(customer);
                        break;


                    case 3:
                        Console.WriteLine("Wait Calculating Your Interest");
                        Console.WriteLine(savingAccount.CalculateInterest(customer).ToString());

                        break;

                    default:
                        Console.WriteLine("EXITING FROM CUSTOMER RELATED INFO ");
                        break;
                }

            } while (Choice != 0);

        }

        public static void SearchCustomerByEmail(List<Customer> customers)
        {
            Console.WriteLine(SEARCH_BY_EMAIL);
            try
            {
                Customer customer = customers.Find(x => x.CustomerEmail == Console.ReadLine());
                DisplayCustomerDetail(customer);
                CustomerRelatedTransactions(customer);

            }
            catch (Exception)
            {
               Console.WriteLine(NO_RESULT_FOUND);
            }
        }


    }
}
