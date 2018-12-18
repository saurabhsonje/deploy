using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employee = new List<Employee>();
        Hr hr = new Hr();
        

        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";
            return View(employee);
        }

        public ActionResult getEmployeeList()
        {
            hr.getList(getSalary);
            return View(employee);
        }

        public void getSalary(List<Employee> emp)
        {
            employee = emp;
        }

        public ActionResult getHighestSalary()
        {
            List<Employee> emp = hr.employeeList();
            IEnumerable<Employee> employee = emp.OrderByDescending(x => x.EmpSalary).Take(1);
            return View(employee);
        }
       
    }

    public class Hr
    {
        public delegate void functionptr(List<Employee> emp);
        public void getList(functionptr obj)
        {
            List<Employee> employees = new List<Employee>();
            employees = employeeList();
            obj(employees);
        }

        public List<Employee> employeeList()
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee(1,"Shreya","Developer",30000),
                new Employee(2,"Vinit" , "Testing" , 20000),
                new Employee(3,"Akash" , "QA" , 4500),
            };
            return employee;
        }
    }
}