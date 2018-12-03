using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Programmer: Employee
    {
        public double incentive { set; get; }
        public Programmer()
        {

        }
        public Programmer(int id,string name,double balance,double incentive) : base(id, name, balance)
        {
            this.incentive = incentive;
           

        }
        public double calSal()
        {
            return this.balance + this.incentive;
        }
    }
}
