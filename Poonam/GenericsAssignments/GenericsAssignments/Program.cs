using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Employee> employees= new List<Employee>()
              {
           new Employee(1, "Neeraj", 20, 12333),
           new Employee(2, "Shreya", 21, 123331),
           new Employee(3, "Poonam", 22, 123338)
              };
            Console.WriteLine("Before Sorting");
            employees.ForEach(x => Console.WriteLine(x.id + " " + x.name + " " + x.age + " " + x.sallary));
            Console.WriteLine("After Sorting");
            Sort<Employee> sort = new Sort<Employee>();
            sort.sortMethod(employees);
            employees.ForEach(x => Console.WriteLine(x.id + " " + x.name + " " + x.age + " " + x.sallary));
            Console.ReadKey();
        }


    }        
}
