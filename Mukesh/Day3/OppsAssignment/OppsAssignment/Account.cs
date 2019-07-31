using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsAssignment
{
    //making abstract class, since need to be implemented in both type of account
    public  abstract class Account
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double AmtDeposit;
        public double AmtWithdraw;
        public static double Balance { get; set; }

        public double deposit()
        {
            Console.WriteLine("Enter the amount to deposit:");
            AmtDeposit =Convert.ToDouble(Console.ReadLine());
            Balance = Balance + AmtDeposit;
            Console.WriteLine("Amount in account:"+Balance+"\n");
            return Balance;
        }

        public double withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw:");
            AmtWithdraw = Convert.ToDouble(Console.ReadLine());
            Balance = Balance - AmtWithdraw;
            Console.WriteLine("Amount in account:" + Balance+"\n");
            return Balance;

        }
        
        public abstract double CalculateInterest();
        
        
    }
}
