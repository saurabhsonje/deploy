using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_A11_1_SP_EF
{
    class Program
    { 
        static void Main(string[] args)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            var employees = employeeDBContext.Employee.SqlQuery("EXEC GetEmployeesList").ToList();
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            
        }
    }


   

   






}
