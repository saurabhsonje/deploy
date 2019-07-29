using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_A08_LINQ
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(int _Id, string _Name , Double _Salary)
        {
            this.Id = _Id;
            this.Name = _Name;
            this.Salary = _Salary;
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
            return "Id->" + " " + Id + " " + "EmpName->" + " " + Name +  " "+ "Salary->" + Salary + System.Environment.NewLine;
        }

    }
}
