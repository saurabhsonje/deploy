using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public String EmpName { get; set; }
        public String EmpDept { get; set; }
        public int EmpSalary { get; set; }

        public Employee()
        {

        }
        public Employee(int EmpId, String EmpName, String EmpDept, int EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpDept = EmpDept;
            this.EmpSalary = EmpSalary;
        }
    }
}