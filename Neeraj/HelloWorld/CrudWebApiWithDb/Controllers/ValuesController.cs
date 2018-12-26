using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDb;

namespace CrudWebApiWithDb.Controllers
{
    public class ValuesController : ApiController
    {

        public IHttpActionResult GetTblEmployees()
        {
            using (EmployeeEntities employeeEntities = new EmployeeEntities())
            {

                try
                {
                    List<tblEmployee> employeeList = employeeEntities.tblEmployees.ToList();

                    return Ok(employeeList);

                }
                catch (ArgumentNullException e)
                {
                    return NotFound();
                }


            }

        }

        public IHttpActionResult GetTblEmployees(int id)
        {
            using (EmployeeEntities employeeEntities = new EmployeeEntities())
            {
                try
                {
                    tblEmployee requestedEmployee = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault(); // throws ArgumentNullException if not found
                 /*   if (requestedEmployee.Equals(null))
                    {
                        return NotFound();
                    }
                    */
                    if (requestedEmployee == null)
                    {
                        return NotFound();
                    }


                    return Ok(requestedEmployee);

                }
                catch (ArgumentNullException e)
                {
                    return NotFound();    
                }


            }

        }

        public HttpResponseMessage PostEmployee([FromBody] tblEmployee employeeAdded)
        {
            using (EmployeeEntities employeeEntities = new EmployeeEntities())
            {

                try
                {
                    if (employeeAdded != null)
                    {
                        employeeEntities.tblEmployees.Add(employeeAdded);
                        employeeEntities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, employeeAdded);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NoContent, "Nothing inside request body");
                    }

                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest,e);
                }
     

            }
        }

        public HttpResponseMessage PutEmployee(int id,[FromBody] tblEmployee employeeFromBody )
        {
         
            try
            {
                using (EmployeeEntities employeeEntities = new EmployeeEntities())
                {

                    tblEmployee employeeFromQuery = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault();

                    if (employeeFromQuery == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, new ArgumentNullException());
                    }
                    else
                    {
                        employeeFromQuery.Name = employeeFromBody.Name;
                        employeeFromQuery.Salary = employeeFromBody.Salary;
                        employeeFromQuery.Dept = employeeFromBody.Dept;
                        employeeEntities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }


        }


        public IHttpActionResult DeleteEmployee(int id)
        {
            try
            {
                using (EmployeeEntities employeeEntities = new EmployeeEntities())
                {

                    tblEmployee employeeFromQuery = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault();

                    if (employeeFromQuery == null)
                    {
                        return NotFound();
                      //  return Request.CreateErrorResponse(HttpStatusCode.NotFound, new ArgumentNullException());
                    }
                    else
                    {
                        employeeEntities.tblEmployees.Remove(employeeFromQuery);
                        employeeEntities.SaveChanges();
                        return Ok();
                        
                        //   return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }


        }




     




    }
}
