using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net.Http;
using System.Net;
using System.Web.Http;

namespace EmployeeManagementSystem.DAO
{
    public class EmployeeDao
    {
        EmployeeDataEntities1 db = new EmployeeDataEntities1();
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
       

        public void DeleteById(int id)
        {
            Employee employee = db.Employees.FirstOrDefault(x => x.EmpId == id);
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

        public Employee GetEmployee(int id)
        {
            return db.Employees.Where(x => x.EmpId == id).FirstOrDefault();

        }
        public void UpdateEmployee(int id, Employee employee)
        {
            Employee employe = db.Employees.Where(x => x.EmpId == id).FirstOrDefault();
            if (employe == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No id with that task={0}", id)),
                    ReasonPhrase = "Not Found"
                };
                throw new HttpResponseException(resp);

            }
            db.Employees.Where(x => x.EmpId == id).FirstOrDefault().EmpName = employee.EmpName;
            db.Employees.Where(x => x.EmpId == id).FirstOrDefault().EmpSalary = employee.EmpSalary;
            db.Employees.Where(x => x.EmpId == id).FirstOrDefault().EmpStudio = employee.EmpStudio;
            db.SaveChanges();
        }

        public Studio GetStudio(int id)
        {
            Studio studio = db.Studios.Where(x => x.StudioId == id).FirstOrDefault();
            return studio;
        }
    }
}