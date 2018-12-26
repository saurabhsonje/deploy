using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }
}
