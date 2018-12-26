using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDb;
using CrudWebApiWithDb.Dao;

namespace CrudWebApiWithDb.Controllers
{
    public class ValuesController : ApiController
    {
        EmployeeDao dao = new EmployeeDao();

        public IHttpActionResult GetTblEmployees()
        {
           List<tblEmployee> employeesList = dao.EmployeeListFromDb();

            if (employeesList != null)
            {
                return Ok(employeesList);
            }
            else
            {
                return NotFound();
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

                if (dao.AddingEmployeeIntoDb(employeeAdded))
                {
                    return Request.CreateResponse(HttpStatusCode.OK);

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "Nothing inside request body");
                }
              
            }
        }

        public HttpResponseMessage PutEmployee(int id,[FromBody] tblEmployee employeeFromBody )
        {

            if (dao.EditingEmployeeinDb(id, employeeFromBody))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

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
