using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{
    class CurrentAccount : Account
    {

        private readonly Double INTERESTRATE;


        public CurrentAccount()
        {
            this.INTERESTRATE = 100;
        }


        public override Double CalculateInterest(Customer customer)
        {
            return customer.Aaccount.AccountBalance * 12 * INTERESTRATE;
        }


        public override string ToString()
        {
            return "AccountNumber => " + Convert.ToString(AccountNumber) + " " + "AccountCreated => "
                + Convert.ToString(AccountCreated) + " " + "AccountType => " + AccountType
                + "AccountBalance =>" + AccountBalance + " " + "INTERESTRATE " + " " + INTERESTRATE;
        }


    }
}
