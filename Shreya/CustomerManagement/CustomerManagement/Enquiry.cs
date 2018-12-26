using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    class Enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            Console.WriteLine("Sorry Customer No Discount for you");
            return TotalSales - 5;
        }
    }
}
