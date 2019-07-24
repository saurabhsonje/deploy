using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{
    class BankUtils
    {


        public static void BankInfo(List<Bank> banks)
        {

            foreach (Bank bank in banks)
            {

                Console.WriteLine(bank.ToString());

                foreach (var customer in bank.Customers)
                {
                    Console.WriteLine(customer.ToString());
                }
            }


        }
    }
}
