using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsAssignment
{
    class Bank
    {
       public void ShowDetails(Customer c)
        {
            Console.WriteLine("\nID:" +c.CustId+"\nName:" +c.CustName +"\nEmail:" +c.CustEmail +"\nSalary:"+c.CustSalary+"\n");

        }
    }
}
