using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            Console.WriteLine("Congrats Customer!! you get Discount of 12%");
            return base.getDiscount(TotalSales) - 50;
        }
    }
}
