using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_A07_List_CURD
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {

        }

        public Employee(int _Id, string _Name)
        {
            this.Id = _Id;
            this.Name = _Name;
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
            return "Id->" + " " + Id + " " + "EmpName->" + " " + Name + System.Environment.NewLine;
        }

    }

}
