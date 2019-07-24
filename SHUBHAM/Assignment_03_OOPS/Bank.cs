using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{
    class Bank
    {

        public int BankId { get; set; }
        public string BankName { get; set; }
        public List<Customer> Customers { get; set; }

        public Bank()
        {
            Customers = new List<Customer>();
        }

        public override string ToString()
        {
            return "BankId => " + BankId.ToString() + " " + "BankName => " + BankName;
        }

    }

}
