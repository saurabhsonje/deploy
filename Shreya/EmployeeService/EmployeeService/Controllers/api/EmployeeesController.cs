using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class EmployeeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }

        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id)  ;
            }

        }

        public IHttpActionResult Post(Employee emp)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                entities.Employees.Add(new Employee()
                {
                    ID = emp.ID,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary,
                    Department = emp.Department

                });

                entities.SaveChanges();
            }

            return Ok();
        }

        public IHttpActionResult Put(Employee emp)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                var existingEmp = entities.Employees.Where(e => e.ID == emp.ID).FirstOrDefault<Employee>();
                if (existingEmp != null)
                {
                    existingEmp.FirstName = emp.FirstName;
                    existingEmp.LastName = emp.LastName;
                    existingEmp.Department = emp.Department;

                    entities.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid Employee ID");

            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                var emp = entities.Employees.Where(e => e.ID == id).FirstOrDefault();
                entities.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                entities.SaveChanges();
            }

            return Ok();
        }
    }
}
