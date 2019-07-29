using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmp = new List<Employee>()
            { new Employee{ ID=12, Name="Rakesh", Salary=30000 },
              new Employee{ ID=12, Name="Rakesh", Salary=40000 },
              new Employee{ ID=12, Name="Rakesh", Salary=80000 },
              new Employee{ ID=12, Name="Rakesh", Salary=50000 },
              new Employee{ ID=12, Name="Rakesh", Salary=100000 }
            };

            var emp = listEmp.OrderByDescending(sal => sal.Salary).Skip(1).First();
            Console.WriteLine("Second Highest salray using lamda Expression:{0}",emp.Salary);

            var Lsal = (from sal in listEmp
                        orderby sal.Salary descending
                        select sal).Skip(1).FirstOrDefault();
            Console.WriteLine("Second Highest salray using LINQ:{0}", Lsal.Salary);


            Console.ReadKey();

        }
    }
}
