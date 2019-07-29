using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_A07_List_CURD
{
     class Operations
    {
        public const string DELETION_NOT_POSSIBLE = "DELETE NOT POSSIBLE------>";
        public const string LIST_IS_EMPTY = "LIST IS EMPTY------->";
        public const string LIST_AFTER_DELETION = "LIST AFTER DELETION------->";
        public const string RECORD_NOT_FOUND = " RECORD NOT FOUND---------->";
        public const string UPDATED_RECORD = "UPDATED RECORD  ------------------> ";



        public void Update(Employee employee)
        {
            if (employee == null)
                Console.WriteLine(RECORD_NOT_FOUND);
            else
            {
                Console.WriteLine(UPDATED_RECORD);
                Console.WriteLine(employee.ToString());
            }
        }


        public void Add(Employee employee)
        {
            if (employee == null)
                Console.WriteLine(RECORD_NOT_FOUND);
            else
            {
                Console.WriteLine(UPDATED_RECORD);
                Console.WriteLine(employee.ToString());
            }
        }



        public void Delete(ref List<Employee> EmployeeList)
        {
            Employee emp = EmployeeUtils.DeleteEmployee(ref EmployeeList);
            if (emp == null)
                Console.WriteLine(DELETION_NOT_POSSIBLE);
            else
            {

                if ( EmployeeUtils.EmployeeListCount(ref EmployeeList) == 0)
                    Console.WriteLine(LIST_IS_EMPTY);
                else
                {
                    Console.WriteLine(LIST_AFTER_DELETION);
                    Display(ref EmployeeList);
                }

            }
        }

        public  void Display(ref List<Employee> EmployeeList)
        {
            EmployeeUtils.Display(ref EmployeeList);
        }

    }
}
