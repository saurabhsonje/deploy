using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Banking_System
{
    public class Bank
    {
        public int Account_Num { get; set; }
        public double Balance { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        public Bank()
        {

        }
        public Bank(int account_Num, double bal)
        {

            this.Account_Num = account_Num;
            this.Balance = bal;

        }
        public Customer CreateCustomer()
        {
           
            Console.WriteLine("Enter Customer Name");
            Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Account Type(Saving/Current)");
            Type = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Account Number");
            Account_Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Intial Account Balance");
            Balance = Convert.ToDouble(Console.ReadLine());

            Customer cust = new Customer(Name, Type, Account_Num, Balance);
            return cust;
        }


        public void AddCustomer(Customer c, List<Customer> customers)
        {
            customers.Add(new Customer(c.Name, c.Type, c.Account_Num, c.Balance));
            Console.WriteLine("-----------------------------------------------------------\n" +
                "Customer_Name | Account_Type | Account_number | Balance\n" +
                "-----------------------------------------------------------");
            Console.WriteLine(c.ToString());
            Console.WriteLine("Account Succefully Created.");
        }

        public void Display_Customer_List(List<Customer> customers)
        {

            Console.WriteLine("-----------------------------------------------------------\n" +
                "Customer_Name | Account_Type | Account_number | Balance\n" +
                "-----------------------------------------------------------");
            foreach (Customer i in customers)
            {
                Console.WriteLine(i.ToString());
            }
        }

        
    }
}
