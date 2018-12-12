using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationEmployeeAssignment.Models;

namespace WebApplicationEmployeeAssignment.Controllers
{
    public class EmployeeController : Controller
    {

        List<Employee> employee = new List<Employee>();
        Hr hr = new Hr();
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";
            return View();
        }
        public ActionResult getEmployeeList()
        {
           
            hr.getList(getSalary);
            return View(employee);
        }
        public void getSalary(List<Employee> emp)
        {
            //var employees = emp.Select(s => new { name = s.name, id = s.id });
            employee = emp;
        }
        public ActionResult getHighestSallary()
        {
           
            List<Employee> emp = hr.employeeList();
            IEnumerable<Employee> employee = emp.OrderByDescending(x => x.salary).Take(1);
            return View(employee);
        }
    }
    public class Hr
    {
        public delegate void functionpt(List<Employee> emp);
        public void getList(functionpt obj)
        {
            List<Employee> employees = new List<Employee>();
            employees = employeeList();
            obj(employees);
        }
        public List<Employee> employeeList()
        {
            List<Employee> employee = new List<Employee>()
               {
                new Employee(1, "Neeraj", 333444),
                new Employee(2, "Shreya", 150000),
                new Employee(3, "Poonam", 233444),
                new Employee(4, "Bhakti", 12233455)
                };

            return employee;
        }
    }
}