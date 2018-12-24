using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustRelationshipManagement
{
    class GoldCustomer : Customer //inheritance
    {
       
        public override void GetCustomerType() // method overrding - run time polymorphism
        {
            Console.WriteLine("This is Gold Customer");
           
            

        }

        public override void GetDiscount()
        {
            int totalDiscount = 15 + discount;
            Console.WriteLine("Discount for him is:{0}", totalDiscount);
        }
    }
}
