using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{
    class SavingAccount : Account
    {

        private readonly Double INTERESTRATE;
        public SavingAccount()
        {
            this.INTERESTRATE = 10;
        }

        public override Double CalculateInterest(Customer customer)
        {
            return customer.Aaccount.AccountBalance * 12 * INTERESTRATE;

        }

        public override string ToString()
        {
            return "AccountNumber => " + Convert.ToString(AccountNumber) + " " + "AccountCreated => "
                + Convert.ToString(AccountCreated) + " " + "AccountType => " + AccountType
                 + "AccountBalance =>" + AccountBalance + " " + "INTERESTRATE => " + " " + INTERESTRATE;
        }


    }
}
