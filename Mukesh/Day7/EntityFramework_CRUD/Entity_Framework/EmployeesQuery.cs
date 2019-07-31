using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class EmployeesQuery
    {
        DataContext empDBContext = new DataContext();

        public List<Employee> GetEmployees()
        {
            return empDBContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            empDBContext.Employees.Add(employee);
            empDBContext.SaveChanges();
        }


        public void UpdateEmployee(Employee employee)
        {   
            Employee empToUpdate= empDBContext.Employees.FirstOrDefault(x=>x.ID == employee.ID);
            empToUpdate.Name = employee.Name;
            empToUpdate.ID = employee.ID;
            empToUpdate.Studio = employee.Studio;
            empToUpdate.Salary = employee.Salary;
            empDBContext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            Employee empToDelete = empDBContext.Employees.FirstOrDefault(x => x.ID == employee.ID);
            empDBContext.Employees.Remove(empToDelete);
            empDBContext.SaveChanges();
        }

    }
}
