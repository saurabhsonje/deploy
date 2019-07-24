using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBanking_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseuse = 1;
            List<Customer> account = new List<Customer>();
            Customer cust = new Customer();

            string Continue;
            string c;
            do
            {
                Console.WriteLine("Enter which operation you want to perform\n1.Create Account\n2.Delete Account\n3.WithdrawMoney\n4.DepositeMoney\n5.want to know interest\n6.check Account balance\n");
                caseuse = int.Parse(Console.ReadLine());
                Account a = new Account();
                Bank bank1 = new Bank();

                switch (caseuse)
                {
                    case 1:

                        cust.GetCustomerInfo();
                        bank1.Create_account(cust, account);
                        break;
                    case 2:
                        bank1.deleteAccount(cust, account);
                        break;
                    case 3:
                        Console.WriteLine("Enter from which account you want to widraw money");
                        c = Console.ReadLine();
                        a.withdrawMoney(c, account);
                        break;
                    case 4:
                        Console.WriteLine("Enter from which account you want to widraw money");
                        c = Console.ReadLine();
                        a.depositeMoney(c, account);
                        break;
                    case 5:
                        Console.WriteLine("Enter from which account you want to calculate interest");
                        c = Console.ReadLine();
                        a.InterestOnBalance(c, account);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter customer name to check balance ");
                        c = Console.ReadLine();
                        a.check_balance(c, account);
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                Console.Write("Do You Want To Continue? (Y/N) : ");
                Continue = Console.ReadLine();

            } while (Continue != "N" && Continue != "n");
        }
    }
}

