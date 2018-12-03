using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        private int id;
        private string name;
        private double balance;

        public Account(int id,string name,double balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;

        }

        public void checkBalance()
        {
            
             Console.WriteLine( "Balance for {0} is: {1}",this.name,this.balance);
        }

        public void credit(double amount)
        {
            this.balance = this.balance + amount;
            Console.WriteLine("Amount credited {0}",amount);
        }

        public void debit(double amount)
        {
            if (this.balance > amount)
            {
                this.balance = this.balance - amount;
                Console.WriteLine("Amount debited {0}", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Amount");
            }
            
        }
    }
}
