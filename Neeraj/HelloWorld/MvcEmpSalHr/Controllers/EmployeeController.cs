using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEmpSalHr.Controllers
{
    public class EmployeeController : Controller
    {
        IList<Models.Employee> empList = new List<Models.Employee>();

        public delegate ActionResult listOfEmp(); 

        listOfEmp employeeList; 

        public void GenerateListOfEmployee()
        {
            employeeList = Index;
            employeeList.Invoke();

        }

        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            
            {
                // new Models.Employee(id=1,name="Neeraj",branch="Scalable",salary=10)
              Models.Employee e1=  new Models.Employee(id: 1, name: "Neeraj", branch: "Scalable", salary: 10);
                Models.Employee e2 = new Models.Employee(id: 2, name: "Ashiq", branch: "IOS", salary: 20);
                Models.Employee e3 = new Models.Employee(id: 3, name: "Raj", branch: "JS", salary: 30);
                Models.Employee e4 = new Models.Employee(id: 4, name: "Neeraj", branch: "Scalable", salary: 15);
                //   empList.Add(1, "Neeraj", "Scalable", 10);
                empList.Add(e1);
                empList.Add(e2);
                empList.Add(e3);

                empList.Add(e4);
            };

           //redirect makes us reload everything and theemplist becomes zero
            return View(empList);
        }

        public ActionResult HighestSalary()
        {
             int maxSal = empList.Max(e => e.salary);
            var highestSalEmp = empList.FirstOrDefault(e => e.salary >= maxSal);
          //  IEnumerable<Models.Employee> highSalEmployee = empList.Where(e =>  e.salary == maxSal);
            return View();
        }

        
        public ActionResult AddEmployee()
        {
            return View();

        }

        [HttpPost]
        public ActionResult AddEmployee(FormCollection values)
        {
            int id =Convert.ToInt32 (values["id"]);
            int salary = Convert.ToInt32(values["salary"]);

            string name = (values["name"]);
            string branch = (values["branch"]);

            Models.Employee employee = new Models.Employee(id, name, branch, salary);
            empList.Add(employee);

            // return RedirectToAction("Index");
            return View("Index");


        }

       // public ActionResult 


    }
}