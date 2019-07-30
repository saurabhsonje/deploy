using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08
{
    class Employee
    {
        public string Emp_name;
        public int Emp_id;
        public double emp_salary;

        public Employee()
        {

        }
        public Employee(string ename, int eid, double esalary)
        {
            Emp_name = ename;
            Emp_id = eid;
            emp_salary = esalary;
        }
        public void GetData()
        {
            Console.WriteLine("Enter Employee Name");
            Emp_name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID");
            Emp_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            emp_salary = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Employee Name:\t" + Emp_name + "\tEmployee Id:\t" + Emp_id + "\tEmployee salary:\t" + emp_salary;
        }


    }
}
