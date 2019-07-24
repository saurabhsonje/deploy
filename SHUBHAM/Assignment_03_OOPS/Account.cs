using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{
    abstract class Account
    {

        public string AccountNumber { get; set; }
        public DateTime AccountCreated { get; set; }
        public Double AccountBalance;
        public string AccountType { get; set; }


        public void Deposit(Customer customer, Double Amount)
        {
            AccountBalance = Amount + customer.Aaccount.AccountBalance;
            customer.Aaccount.AccountBalance = AccountBalance;
        }

        public void Withdrow(Customer customer, Double Amount)
        {
            AccountBalance = AccountBalance - Amount;
            customer.Aaccount.AccountBalance = AccountBalance;
        }

        public abstract Double CalculateInterest(Customer customer);

    }

}
