using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_GenericClass
{

    class Program
    {

        enum OPERATION
        { EXIT, INSERTION, DISPLAY, DELETION };


        public static readonly string ENTER_CHOICE = "ENTER THE CHOICE";
        public static readonly string ONE_FOR_INSERTION = "ENTER 1 FOR INSERTION ";
        public static readonly string TWO_FOR_DISPLAY = "ENTER 2 FOR DISPLAY";
        public static readonly string THREE_FOR_DELETION = "ENTER 3 FOR  DELETION";
        public static readonly string ZERO_FOR_EXIT = "ENTER ZERO FOR EXIT";
        public static readonly string ENTER_ID = "ENTER THE ID OF EMPLOYEE";
        public static readonly string ENTER_NAME = "ENTER NAME OF EMPLOYEE ";


       

        static void Main(string[] args)
        {
            Initilization();
        }


        public static void Initilization()
        {

            Int16 choice = 0;
            GenericClass<Employee> GenericEmployee = new GenericClass<Employee>();

            do
            {
                Console.WriteLine();
                Console.WriteLine(ONE_FOR_INSERTION);
                Console.WriteLine(TWO_FOR_DISPLAY);
                Console.WriteLine(THREE_FOR_DELETION);
                Console.WriteLine(ZERO_FOR_EXIT);
                Console.WriteLine(ENTER_CHOICE);
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case (int)OPERATION.INSERTION :
                        Employee emp = EnterEmployeeDetails();
                        GenericEmployee.AddEntity(emp); 
                        break;

                    case (int)OPERATION.DISPLAY:
                        GenericEmployee.DisplayList();  
                        break;

                    case (int)OPERATION.DELETION :
                        Employee em = EnterEmployeeDetails();
                        Console.WriteLine(em.GetHashCode() + "--------------->");
                        GenericEmployee.DeleteEntity(em);  
                        break;


                    default: System.Environment.Exit(0);
                             break;
                }


            } while (choice != 0);
            Console.ReadLine();

        }


        public static Employee EnterEmployeeDetails()
        {

            Console.WriteLine(ENTER_ID);
            Int16 Id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(ENTER_NAME);
            string Name = Console.ReadLine();
            Employee emp = new Employee() { Id = Id, EmpName = Name };
            Console.WriteLine(emp.GetHashCode() + "--------------->");
            return emp;
        }


    }
}
