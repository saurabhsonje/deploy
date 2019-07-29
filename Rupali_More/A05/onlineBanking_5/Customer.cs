using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBanking_5
{
    class Customer
    {
        public string Customer_name;
        public string Customer_Add;
        public int Type_of_Account;
        public int phone_no;
        public double Balance;
        string val;

        public Customer()
        {
            //default constructor 
        }

        //parameterize constructor for customer class
        public Customer(string c_name, string c_add, int type_ac, int p_no, double a_bal)
        {
            Customer_name = c_name;
            Customer_Add = c_add;
            Type_of_Account = type_ac;
            phone_no = p_no;
            Balance = a_bal;
        }
        //gathering requied information from customer 
        public void GetCustomerInfo()
        {
            Console.WriteLine("Enter customer name");
            Customer_name = Console.ReadLine();
            Console.WriteLine("Enter customer Address");
            Customer_Add = Console.ReadLine();
            Console.WriteLine("Enter which type of Account you want saving(1) and current(0)");
            val = Console.ReadLine();
            Type_of_Account = int.Parse(val);
            Console.WriteLine("Enter customer phone number");
            val = Console.ReadLine();
            phone_no = int.Parse(val);
            Console.WriteLine("Enter money customer want to deposite at the time of account opening");
            val = Console.ReadLine();
            Balance = int.Parse(val);

        }
        public override string ToString()
        {

            return "Customer Name\t" + " " + Customer_name + ": Customer Address\t" + Customer_Add + ": Bank account Type\t" + Type_of_Account + ": Phone Number\t" + phone_no + "Account balance" + Balance.ToString();
        }


    }
}
