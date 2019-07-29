using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_04_A07_List_CURD
{
    class EmployeeUtils
    {


        public const string ENTER_ID = "ENTER THE ID OF EMPLOYEE";
        public const string ENTER_NAME = "ENTER NAME OF EMPLOYEE ";
        public const string ENTER_NAME_SEARCH= "ENTER THE NAME OF EMPLOYEE YOU WANT TO SEARCH";
        public const string ENTER_NEW_NAME = "ENTER NEW NAME";
        public const string EMPLOYEE_INSERTED = "EMPLOYEE INSERTED------> ";
        public const string EMPLOYEE_FAILED_INSERTED = "NOT INSERTED----->";



        public static void AddEmployee(ref List<Employee> Employees, ref Employee Employee)
        {
            try
            {
                foreach (var item in Employees)
                {
                    if (item.Id == Employee.Id)
                    {
                        Console.WriteLine("ID ALREADY EXISTS---->");
                        throw new Exception();
                    }
                        
                }

                Employees.Add(Employee);
                Console.WriteLine(EMPLOYEE_INSERTED);
            }
            catch (Exception)
            {
                Console.WriteLine(EMPLOYEE_FAILED_INSERTED);
            }

        }


        public static int EmployeeListCount(ref List<Employee> Employees)
        {
            return Employees.Count();
        }

        public static Employee UpdateEmployee(ref List<Employee> Employees)
        {

            if (EmployeeListCount(ref Employees) == 0)
                return null;

            Employee employee = SearchEmployeeByName(ref Employees);

            if (employee == null)
               return null;

            Console.WriteLine(ENTER_NEW_NAME);
            employee.Name = Console.ReadLine();
            return employee;
        }


        public static Employee DeleteEmployee(ref List<Employee> Employees)
        {
            try
            {
                Employee employee = SearchEmployeeById(ref Employees);
                if (employee == null)
                    throw new Exception();

                Employees.Remove(employee);
                return employee;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static void Display(ref List<Employee> EmployeeList)
        {
            if (EmployeeListCount(ref EmployeeList) == 0)
            {
                Console.WriteLine("LIST IS EMPTY ");
            }
            else
            {
                foreach (var item in EmployeeList)
                Console.WriteLine(item);
            }

           
        }


        public static Employee SearchEmployeeByName(ref List<Employee> employee)
        {
            Console.WriteLine(ENTER_NAME_SEARCH);
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("NAME CAN'T BE EMPTY! ");
                name = Console.ReadLine().Trim().ToLower();
            }
            while (!Regex.IsMatch(name, "[a-zA-Z]"))
            {
                Console.WriteLine("ENTER VALID CHARACTERS  ");
                name = Console.ReadLine().Trim().ToLower();
            }
            try
            {
                Employee Employee = employee.Find(x => x.Name.ToLower() == name);
                return Employee;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Employee SearchEmployeeById(ref List<Employee> employee)
        {
            Console.WriteLine(ENTER_ID);
            try
            {
                //Employee Employee = employee.Find(x => x.Id == Convert.ToInt32(Console.ReadLine()));


                int Id = 0;
                var idAsString = Console.ReadLine();
                while (!int.TryParse(idAsString, out Id))
                {
                    Console.WriteLine("ID MUST BE A NUMBER!");
                    idAsString = Console.ReadLine();
                }
                Employee Employee = employee.Where( x => x.Id == Id).SingleOrDefault();
                return Employee;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public static Employee EnterEmployeeDetails()
        {
            int Id;
            Console.WriteLine(ENTER_ID);
            var idAsString = Console.ReadLine();
            while (!int.TryParse(idAsString, out Id))
            {
                Console.WriteLine("ID MUST BE A NUMBER!");
                idAsString = Console.ReadLine();
            }
            Console.WriteLine(ENTER_NAME);
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("NAME CAN'T BE EMPTY! ");
                name = Console.ReadLine();
            }
            while (!Regex.IsMatch(name, "[a-zA-Z]"))
            {
                Console.WriteLine("ENTER VALID CHARACTERS  ");
                name = Console.ReadLine();
            }
            Employee employee = new Employee() { Id = Id, Name = name };
            return employee;
        }

    }
}
