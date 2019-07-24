using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBanking_5
{
    class Account : Bank
    {
        private double w_money, d_money;
        string val;
        public void check_balance(string c, List<Customer> account)
        {
            foreach (var person in account)
            {
                if (person.Customer_name == c)
                {
                    Console.WriteLine("your account balance is:{0}", person.Balance);
                }
            }
        }

        public void withdrawMoney(string c, List<Customer> account)
        {
            Console.WriteLine("Enter how much money you want to withdraw");
            val = Console.ReadLine();
            w_money = double.Parse(val);
            foreach (var person in account)
            {
                if (person.Customer_name == c)
                {
                    person.Balance = person.Balance - w_money;
                    Console.WriteLine("your account balance is:{0}", person.Balance);
                }
            }

            foreach (var i in account)
            {
                Console.WriteLine(i);
            }

        }

        //deposite money into bank account
        public void depositeMoney(string c, List<Customer> account)
        {
            Console.WriteLine("Enter how much money you want to deposite");
            val = Console.ReadLine();
            d_money = double.Parse(val);
            foreach (var person in account)
            {
                if (person.Customer_name == c)
                {
                    person.Balance = person.Balance - d_money;
                    Console.WriteLine("your account balance is:{0}", person.Balance);
                }
            }
            try
            {
                foreach (var i in account)
                {
                    Console.WriteLine(i);
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range exception occure");
            }

        }

    }
}
