using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.DAO
{
    public class EmployeeDao
    {
        EmployeeDataEntities db = new EmployeeDataEntities();
        public bool AddEmployee(Employee employee)
        {
            try
            {
                if (db.Studios.Any(x => x.EmpStudio == employee.EmpStudio))
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return true;

                }
                else
                {
                    return false;
                }



            }
            catch (Exception e)
            {

                throw new Exception("There was a problem saving this record: " + e.Message);
            }

        }
        public List<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }
    }
}