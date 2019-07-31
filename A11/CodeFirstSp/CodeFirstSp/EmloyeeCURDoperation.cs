using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSp
{
   public class EmloyeeCURDoperation
    {
        EmployeeDbContext employeeDbContext = new EmployeeDbContext();
        public List<EmployeeCodeFirst> GetEmployees()
        {
            return employeeDbContext.employee.ToList();
        }
                     
        public void InsertEmployee(EmployeeCodeFirst employee)
        {
            employeeDbContext.employee.Add(employee);
            employeeDbContext.SaveChanges();
        }

        public void DeleteEmployee(EmployeeCodeFirst employee)
        {
           EmployeeCodeFirst employeeResult =employeeDbContext.employee.FirstOrDefault(x => x.Id == employee.Id);
            employeeDbContext.employee.Remove(employeeResult);
            employeeDbContext.SaveChanges();
        }

        public void UpdateEmployee(EmployeeCodeFirst employee)
        {
            EmployeeCodeFirst employeeResult = employeeDbContext.employee.FirstOrDefault(x => x.Id == employee.Id);
            employee.Name = "xyw";
            employee.Salary = 2345;
            employeeDbContext.SaveChanges();
        }
    }
}
