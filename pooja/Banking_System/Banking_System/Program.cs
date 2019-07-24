using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> Customer = new List<Customer>();
            Customer cust = null;
            Account account = new Account();
            Bank bank = new Bank();
            double Value=0;
            char ch;
           
            Console.WriteLine("------------Bank System----------");

            do
            {
                try
                {
                    int choice;
                    Console.WriteLine("----------------------------------\n");
                    Console.WriteLine("1.Add Customer");
                    Console.WriteLine("2.Credit To Account");
                    Console.WriteLine("3.Withdraw Money From Account");
                    Console.WriteLine("4.Check Balance");
                    Console.WriteLine("5.Check Interest for One Year on Available Balance.");
                    Console.WriteLine("6.Customer List");
                    Console.WriteLine("----------------------------------\n");
                    Console.WriteLine("Enter Your Choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            cust =  bank.CreateCustomer();
                            bank.AddCustomer(cust, Customer);
                            break;

                        case 2:
                            account.Credit(Value, Customer);
                            break;

                        case 3:
                            account.WithDraw(Value, Customer);
                            break;

                        case 4:
                            account.Avail_Bal(Customer);
                            break;

                        case 5:
                            account.CalculateInterest(Customer);
                            break;

                        case 6:
                            bank.Display_Customer_List(Customer);
                            break;
                    }
                }
                catch (Exception e)
                {
                  
                    Console.WriteLine("Exception Occured :"+ e.Message);
                }

                Console.WriteLine("Do You Want To Continue");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch.Equals('y') || ch.Equals('Y'));

            Console.ReadLine();
        }


    }
}