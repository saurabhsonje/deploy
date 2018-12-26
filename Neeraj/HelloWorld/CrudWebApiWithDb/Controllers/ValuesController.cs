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

            tblEmployee requestedEmployee =  dao.RetrieveEmployeeFromDb(id);

            if (requestedEmployee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(requestedEmployee);
            }

        }

        public HttpResponseMessage PostEmployee([FromBody] tblEmployee employeeAdded)
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

            bool status = dao.DeleteEmployeeFromDb(id);
            if (status == false)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        
        }




     




    }
}
