using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Customer
    {
       public string custName { get; set; }
        public  Customer(string name)
        {
            custName = name;
        }
        public Customer()
        {

        }
    }
}
