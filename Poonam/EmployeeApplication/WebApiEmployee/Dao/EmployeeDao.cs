using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net.Http;
using System.Net;
using System.Web.Http;

namespace WebApiEmployee.Dao
{
    public class EmployeeDao : IEmployeeDao
    {
        EmployeeEntities1 db = new EmployeeEntities1();
        public List<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }
        public Employee GetEmployee(int id)
        {
          return db.Employees.Where(x => x.id == id).FirstOrDefault();
           
        }
        public bool AddEmployee(Employee employee)
        { 
           try
          {
                if (db.Employees.Any(x => x.id == employee.id))
                {
                    return false;
                }
                db.Employees.Add(employee);
                db.SaveChanges();
                return true;
            }
           catch (Exception e)
           {
             throw new Exception("There was a problem saving this record: " + e.Message);
            }
          
        }

        public void DeleteEmployee(int id)
        {
           Employee employee= db.Employees.Where(x => x.id == id).FirstOrDefault();
            if (employee == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No id with that task={0}", id)),
                    ReasonPhrase = "Not Found"
                };
                throw new HttpResponseException(resp);

            }
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            Employee employe = db.Employees.Where(x => x.id == id).FirstOrDefault();
            if (employe == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No id with that task={0}", id)),
                    ReasonPhrase = "Not Found"
                };
                throw new HttpResponseException(resp);

            }
            db.Employees.Where(x => x.id == id).FirstOrDefault().name = employee.name;
            db.Employees.Where(x => x.id == id).FirstOrDefault().age = employee.age;
            db.Employees.Where(x => x.id == id).FirstOrDefault().salary = employee.salary;
            db.SaveChanges();
        }
    }
}