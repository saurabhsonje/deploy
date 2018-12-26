using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EmployeeDb;
using CrudWebApiWithDb;

namespace CrudWebApiWithDb.Controllers
{
    public class HomeController : Controller
    {
        EmployeeClientToServer request = new EmployeeClientToServer();

        public ActionResult getAllEmployees()
        {
            List<tblEmployee> employeeList = request.EmployeeList();
            if (employeeList == null)
            {
                return null;
            }
            else
            {
                return View(employeeList);
            }


        }

        public ActionResult AddEmployee()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(FormCollection data)
        {
            bool status = request.AddEmployee(data);
           // tblEmployee employee= request.AddEmployee(data);
            if (status==false)
            {
                return null;           
                
            }
            else
            {
                return View("SuccessAdded");
            }

            

        }

        
        public ActionResult EditEmployee(int id)
        {
            try
            {

                using (EmployeeEntities employeeEntities = new EmployeeEntities())
                {
                    tblEmployee employee = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault();

                    if (employee == null)
                    {
                        return null;
                    }


                    return View(employee);
                }
                
            }
            catch(NullReferenceException ne)
            {
                return null;
            }

        }


        [HttpPost]
        public  ActionResult EditEmployee(tblEmployee employee)
        {
            bool status = request.UpdateEmployee(employee);

            if (status == true)
            {
              
                return View("SuccessUpdate");
            }
            else
            {
                return null;
            }

        }


        public ActionResult DeleteEmployee(int id)
        {
            try
            {

                using (EmployeeEntities employeeEntities = new EmployeeEntities())
                {
                    tblEmployee employee = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault();

                    if (employee == null)
                    {
                        return null;
                    }


                    return View(employee);
                }

            }
            catch (NullReferenceException ne)
            {
                return null;
            }


        }

        [HttpPost]
        public  ActionResult DeleteEmployee(tblEmployee employee)
        {
            bool status = request.DeleteEmployee(employee);

            if (status == true)
            {
                return View("SuccessDelete");
            }
            else
            {
                return null;
            }

        }
    }
}
