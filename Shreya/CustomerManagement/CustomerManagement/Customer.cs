using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    class Customer 
    {
        private FileLogger obj = new FileLogger();

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
