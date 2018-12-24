using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApplication
{
    class GoldCustomer:Customer
    {
        public override double getDiscount()
        {
            return 100;
        }
    }
}
