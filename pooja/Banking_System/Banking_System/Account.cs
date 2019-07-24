using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Account : Bank
    {
       
       
        public Account()
        {
            
        }
        public Account(int account_Num, double bal)
        {
            this.Account_Num = account_Num;
            this.Balance = bal;
        }
        
        public void Credit(double Value, List<Customer> customers)
        {
           
            Console.WriteLine("Enter Customer Name/AccountNumber To deposit Amount:");
            string check = Console.ReadLine();

            Customer customer = customers.Where(x => ((x.Name == (check)) ||
                              (x.Account_Num == Convert.ToInt32(check)))).FirstOrDefault();

            if (customer!= null) 
            {            
                Console.WriteLine("Enter Amount to be Deposited");
                Value = Convert.ToDouble(Console.ReadLine());
                customer.Balance = customer.Balance + Value;
                Console.WriteLine("Current Balance in Account is " + customer.Balance);

            }
            else
            {
                Console.WriteLine("Account/ Customer DoesNot exist");
            }
        }

        public double WithDraw(double Value, List<Customer> customers)
        {
            Console.WriteLine("Enter Customer Name/AccountNumber To Withdraw Amount:");
            string check = Console.ReadLine();

            Customer customer = customers.Where(x => ((x.Name == (check)) ||
                                (x.Account_Num == Convert.ToInt32(check)))).FirstOrDefault();
            if (customer != null)
            {
                Console.WriteLine("Enter Amount to be Withdraw ");
                Value = Convert.ToDouble(Console.ReadLine());
                this.Balance = this.Balance - Value;
                Console.WriteLine("Current Balance in Account is " + this.Balance);
                return Balance;
            }
            else
            {
                Console.WriteLine("Account/ Customer DoesNot exist");
                return 0;
            }
        }

        public double Avail_Bal(List<Customer> customers)
        {
           
            Console.WriteLine("Enter Customer Name/AccountNumber To Show/Display Amount:");
            string check = Console.ReadLine();

            Customer customer = customers.Where(x => ((x.Name == (check)) ||
                                (x.Account_Num == Convert.ToInt32(check)))).FirstOrDefault();
            if (customer != null)
            {
                Console.WriteLine("Available balance :=" + customer.Balance);
                return Balance;
            }
            else
            {
                Console.WriteLine("Account/ Customer DoesNot exist");
                return 0;
            }
        }

        public void CalculateInterest(List<Customer> customers)
        {

            Console.WriteLine("Enter Customer Name/AccountNumber To Show/Display Amount:");
            string check = Console.ReadLine();

            Customer customer = customers.Where(x => ((x.Name == (check)) ||
                                (x.Account_Num == Convert.ToInt32(check)))).FirstOrDefault();
            if (customer != null)
            {
                if (customer.Type == "Saving")
                {
                    Saving_Account_Type SAT = new Saving_Account_Type();
                    SAT._CalculateInterest(customer.Balance);
                }
                else
                if (customer.Type == "Current")
                {

                    Current_Account_Type CAT = new Current_Account_Type();
                    CAT._CalculateInterest(customer.Balance);
                }
                else
                {
                    Console.WriteLine("This type of Account Does Not match with any Existing...!!!");
                }
            }
            else
            {
                Console.WriteLine("Account/ Customer DoesNot exist");

            }
        }

    }

    class Saving_Account_Type : Account
    {
        static readonly int Rate_SAT;

        static Saving_Account_Type()
        {
            Rate_SAT = 12;
        }

        public void _CalculateInterest(double bal)
        {
            double interest;
            interest = (bal * Rate_SAT * 1) / 100;
            Console.WriteLine("Interest :"+interest);
        }
    }

    class Current_Account_Type : Account
    {
        static readonly int Rate_CAT;

        static Current_Account_Type()
        {
            Rate_CAT = 10;
        }

        public void _CalculateInterest(double bal)
        {
            double interest ;
            interest = (bal * Rate_CAT * 1) / 100;
            Console.WriteLine("Interest :" + interest);
        }
    }
}

