using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBanking_5
{
    class Bank
    {

        public double rate, interest, time = 1;
        public void Create_account(Customer c, List<Customer> account)
        {
            account.Add(new Customer(c.Customer_name, c.Customer_Add, c.Type_of_Account, c.phone_no, c.Balance));
            foreach (var i in account)
            {
                Console.WriteLine(i);
            }
        }
        public void deleteAccount(Customer c, List<Customer> account)
        {
            string cust_name;
            Console.WriteLine("Please Enter which account you want to delete");
            cust_name = Console.ReadLine();
            var cust = account.Where(a => a.Customer_name == cust_name).FirstOrDefault();
            account.Remove(cust);
            Console.WriteLine("Account deleted :)");
            foreach (var i in account)
            {
                Console.WriteLine(i);
            }
        }
        public void InterestOnBalance(string c, List<Customer> account)
        {
            foreach (var person in account)
            {
                if (person.Customer_name == c)
                {
                    if (person.Type_of_Account == 0)
                    {
                        rate = 12;
                        interest = (person.Balance * rate * time) / 100;
                        Console.WriteLine("Interest on current account " + interest);
                    }
                    else
                    {
                        rate = 14;
                        interest = (person.Balance * rate * time) / 100;
                        Console.WriteLine("Interest on saving account" + interest);
                    }
                }
            }

        }

    }
}
