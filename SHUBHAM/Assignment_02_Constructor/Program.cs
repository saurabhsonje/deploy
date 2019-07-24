using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_Constructor
{

    class Employee {



        public readonly static string STATIC_CONSTRUCTOR = "Static constructor is called implicitly when the class is Loaded first time in the memeory";
        public readonly static string  DEFAULT_CONSTRUCTOR = "Default constructor";
        public readonly static string PARAMETERIZED_CONSTRUCTOR = "Parameterized constructor";


        static Employee()
        {
            Console.WriteLine(STATIC_CONSTRUCTOR);
        }

        public Employee() : this("XYZ")
        {
            Console.WriteLine(DEFAULT_CONSTRUCTOR);
        }

        public Employee(string FirstName)
        {
            this.FirstName = FirstName;
            Console.WriteLine(PARAMETERIZED_CONSTRUCTOR + " "+ FirstName);
        }

        public string FirstName { get; set; }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee();
            Employee employeeTwo = new Employee();
            Employee employeeThree = new Employee("ABC");
        }
    }
}


