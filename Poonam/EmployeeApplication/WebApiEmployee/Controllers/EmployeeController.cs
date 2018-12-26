using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEmployee.Dao;

namespace WebApiEmployee.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeDao dao = new EmployeeDao();
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return dao.GetEmployees();
        }
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            Employee employee = dao.GetEmployee(id);
          
            if (employee == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No id with that task={0}", id)),
                    ReasonPhrase = "Not Found"
                };
                throw new HttpResponseException(resp);

            }
            return employee;
        }
        [HttpPost]
        public bool AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No data present in the header")),
                    ReasonPhrase = "Not Found Data in the Header"
                };
                throw new HttpResponseException(resp);

            }
            if(dao.AddEmployee(employee))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpDelete]
        public void DeleteEmployee(int id)
        {
            dao.DeleteEmployee(id);
        }
        [HttpPut]
        public void UpdateEmployee(int id,Employee employee)
        {
            dao.UpdateEmployee(id,employee);
        }
    }
}
