using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_GenericClass
{
    class Employee
    {

        public int Id { get; set; }
        public string EmpName { get; set; }

        public Employee()
        {

        }

        public Employee(int Id, string EmpName)
        {
            this.Id = Id;
            this.EmpName = EmpName;
        }

        public override bool Equals(Object obj)
        {
            return Equals(obj as Employee);
        }


        public bool Equals(Employee employee)
        {
            return this.Id == employee.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return "Id->" +" "+ Id + " " + "EmpName->" +" "+EmpName+System.Environment.NewLine;
        }

    }
}
