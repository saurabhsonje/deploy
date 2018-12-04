using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Program
    {
        public String customerName;
        public int customerId;
        public float accountBalance;
        public float withdrawAmount;
        public float depositAmount;

        public Program(int customerId , String customerName , float accountBalance )
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.accountBalance = accountBalance;
        }

        public void Display()
        {
            Console.WriteLine("The Customer Details are: " + customerId + " " + customerName + " " + accountBalance);
        }

        public void Deposit()
        {
            depositAmount = 100.50f;
            accountBalance = accountBalance + depositAmount;
            Console.WriteLine("Amount deposited is " + depositAmount);
            Console.WriteLine("Account Blanace is " + accountBalance);
        }

        public void Withdraw()
        {
            withdrawAmount = 500.50f;
            accountBalance = accountBalance - withdrawAmount;
            Console.WriteLine("Amount withdrawn is " + withdrawAmount);
            Console.WriteLine("Account Blanace is " + accountBalance);
        }

        public static void Main12(string[] args)
        {
            Program p1 = new Program(1, "Vijay", 5000.50f);
            Program p2 = new Program(2, "Kishor", 1000.45f);
            Program p3 = new Program(3, "Lalita", 500.10f);
            p1.Display();
            p1.Withdraw();
            p2.Display();
            p2.Deposit();
            p3.Display();
            Console.ReadLine();
        }
    }
}
