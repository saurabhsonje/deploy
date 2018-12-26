using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignments
{
    class Employee:IGetValue,IComparable<Employee>
    {
    
        public int id { set; get; }
        public string name { set; get; }
        public int age { set; get; }
        public double salary { set; get; }
        public Employee()
        {

        }
        public Employee(int id, string name, int age, double salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;

        }


        public int GetData()
        {
            return age;
        }

        public int CompareTo(Employee employee)
        {
            if (this == employee)
                return 0;
            if (this.age < employee.age)
                return 1;
            else if (this.age == employee.age)
                return 0;
            else
                return -1;
        }
    }
}
