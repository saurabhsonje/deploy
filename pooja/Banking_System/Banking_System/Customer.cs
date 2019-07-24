using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Customer : Bank
    {
              
        public  Customer(string Name, string account_Type,int acc , double bal)
        {
            this.Name = Name;
            this.Type = account_Type;
            this.Account_Num = acc;
            this.Balance = bal;
        }

        public Customer()
        {
        }


        public override string ToString()
        {
            return (Name + " \t\t| " + Type + "\t\t | " + Account_Num + "\t\t | " + Balance);
        }
    }
}
