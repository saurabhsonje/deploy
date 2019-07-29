using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

           
            List<Employee> employees = new List<Employee>();
           
            employees.Add(new Employee(1, "Pooja", "Pune", 200000));
            employees.Add(new Employee(4, "Raks", "Pune", 350000));
            employees.Add(new Employee(2, "Raji", "Pune", 300000));
            employees.Add(new Employee(3, "Pachu", "Pune", 400000));


            var _Result = from emp in employees
                          orderby emp.Salary descending
                          select emp;

            var Result_ = employees.OrderByDescending(emp => emp.Salary);



            Console.WriteLine("Id\tLocation\tName\tSalary");

            foreach (var emp in _Result)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}", emp.Id, emp.Location, emp.Name, emp.Salary);

            }

            Console.WriteLine("\nId\tLocation\tName\tSalary");

            foreach (Employee emp in Result_)
            {

                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}", emp.Id, emp.Location, emp.Name, emp.Salary);
            }



            var _Result1 = (from emp in employees
                            orderby emp.Salary descending
                            select emp).Distinct().Skip(1).FirstOrDefault();

            var Result1_ = employees.OrderByDescending(emp => emp.Salary).Distinct().Skip(1).FirstOrDefault();

            Console.WriteLine("\nEmployee who having second highest salary :");

            Console.WriteLine("Id\tLocation\tName\tSalary");
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3}", _Result1.Id, _Result1.Location, _Result1.Name, _Result1.Salary);


            Console.WriteLine("\nId\tLocation\tName\tSalary");
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3}", Result1_.Id, Result1_.Location, Result1_.Name, Result1_.Salary);

            Console.ReadLine();


        }
    }
}

