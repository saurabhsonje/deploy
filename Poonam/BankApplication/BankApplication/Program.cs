using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            BankAccount account=null;
            double amount;
            char ch;
            int count = 0;
            
                do
                {
                try
                {
                    Console.WriteLine("1.Add Customer");
                    Console.WriteLine("2.Add Credit To Account");
                    Console.WriteLine("3.Withdraw Money From Account");
                    Console.WriteLine("4.Check Balance");
                    int choice;
                    Console.WriteLine("Enter Your Choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Customer Name");
                            string name = Convert.ToString(Console.ReadLine());
                            Customer cust = new Customer(name);
                            count++;
                            Console.WriteLine("Enter Customer Balance");
                            double balance = Convert.ToDouble(Console.ReadLine());
                            account = acc.addCustomer(cust, count, balance);
                            break;
                        case 2:
                            Console.WriteLine("Enter Amount to be Deposited");
                            amount = Convert.ToDouble(Console.ReadLine());
                            account.credit(amount);
                            Console.WriteLine("Current Balance in Account is " + account.custBalance);
                            break;

                        case 3:
                            Console.WriteLine("Enter Amount to be Withdraw ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            account.withdraw(amount);
                            Console.WriteLine("Current Balance in Account is " + account.custBalance);
                            break;
                        case 4:
                            Console.WriteLine("Current Balance in Account is " + account.custBalance);
                            break;

                    }
                }
                catch(Exception exe)
            {
                    Console.WriteLine("Enter Only integer Value As An Choice");
            }

                    Console.WriteLine("Do You Want To Continue");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch.Equals('y')||ch.Equals('Y'));
         

        }
    }
}
