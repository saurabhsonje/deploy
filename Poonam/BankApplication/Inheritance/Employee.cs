using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
       public int id { set; get; }
       public string name { set; get; }
        public double balance { set; get; }
        public Employee()
        {

        }
        public Employee(int id, string name, double balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public double calSal()
        {
            return this.balance;
        }

    }
}
