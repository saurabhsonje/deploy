using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSp
{
    public class EmployeeCodeFirst
    {
        public EmployeeCodeFirst()
        {

        }
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return "Id" + Id;
        }
    }
}
