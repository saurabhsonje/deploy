using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class BankAccount
    {
        public string custName { set; get; }
        public int custId { set; get; }
        public double custBalance { set; get; }
        public BankAccount()
        {

        }
        public BankAccount(string name,int id,double balance)
        {
            this.custName = name;
            this.custId = id;
            this.custBalance = balance;
       
        }
        public double withdraw(double amount)
        {
            if(this.custBalance<500)
            {
                Console.WriteLine("Insufficent Balance"+this.custBalance);
            }
           return this.custBalance = this.custBalance - amount;
        }
        public void credit(double amount)
        {
                this.custBalance = this.custBalance + amount;
        }
        public BankAccount addCustomer(Customer cust,int id,double balance)
        {
          
            BankAccount account = new BankAccount(cust.custName,id,balance);
            return account;
        }
    }
}
