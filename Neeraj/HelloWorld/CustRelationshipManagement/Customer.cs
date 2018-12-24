using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustRelationshipManagement;

namespace CustRelationshipManagement
{
    class Customer : Enquiry,IDiscount,ICustomLogger  // inheritance
    {
       public int discount = 5; 
        public virtual void GetCustomerType() 
        {
            Console.WriteLine("This is a normal Customer");
            
        }

        public virtual void GetDiscount() 
        {
            Console.WriteLine("Discount for him is:{0}", discount);
        }

        public void setLoggin(int customerChoice)
        {
            if (customerChoice == 1)
            {
                Console.WriteLine("Text Message Sent");
            }

            if (customerChoice == 2)
            {
                Console.WriteLine("Email Sent");
            }


        }

 


    }
}
