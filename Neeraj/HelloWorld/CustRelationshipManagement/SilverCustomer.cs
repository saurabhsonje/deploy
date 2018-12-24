using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustRelationshipManagement
{
    class SilverCustomer : Customer
    {
        public override void GetCustomerType()
        {
            Console.WriteLine("This is Silver Customer");
            
        }

        public override void GetDiscount()
        {
            int totalDiscount = 5 + discount;
            Console.WriteLine("Discount for him is:{0}", totalDiscount);
        }
    }
}
