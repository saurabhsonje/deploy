using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Bank
    {
       public String CustomerName;
       public int CustomerId;
       public float AccountBalance;
       public float WithdrawAmount;
       public float DepositAmount;
       public int amount1, amount2;

       public Bank(int CustomerId, String CustomerName, float AccountBalance)
        {
            this.CustomerName = CustomerName;
            this.CustomerId = CustomerId;
            this.AccountBalance = AccountBalance;             
        }

        public void Display()
        {
            Console.WriteLine("The Customer Info is :" + CustomerId + " " + CustomerName + " " + AccountBalance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the withdraw amount");
            amount1 = int.Parse(Console.ReadLine());
            AccountBalance = AccountBalance - amount1;
            Console.WriteLine("The account balance of "+ CustomerName + " is " + AccountBalance);
        }

        public void Deposit()
        {
            Console.WriteLine("Enter the deposit amount");
            amount2 = int.Parse(Console.ReadLine());
            AccountBalance = AccountBalance + amount2;
            Console.WriteLine("The account balance of " +CustomerName + " is " + AccountBalance);
        }
    }
}
