using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            int choice = 0;
            GenericClass<Employee> GenericEmployee = new GenericClass<Employee>();

            do
            {


                string[] Menus = { ZERO_FOR_EXIT, ONE_FOR_INSERTION,
                                   TWO_FOR_DISPLAY, THREE_FOR_DELETION,
                                    ENTER_CHOICE};


                MenuPrinting(ref Menus);


                var choiceAsString = Console.ReadLine();

                while (!int.TryParse(choiceAsString, out choice))
                {
                    Console.WriteLine("CHOICE MUST BE AN INTEGER!");
                    choiceAsString = Console.ReadLine();
                }
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
                      //  Console.WriteLine(em.GetHashCode() + "--------------->");
                        GenericEmployee.DeleteEntity(em);  
                        break;


                    default: System.Environment.Exit(0);
                             break;
                }


            } while (choice != 0);
            Console.ReadLine();

        }

        public static void MenuPrinting(ref string[] Menus)
        {
            foreach (var Menu in Menus)
                Console.WriteLine(Menu);
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
            Employee employee = new Employee() { Id = Id, EmpName = name };
            return employee;
        }


    }
}
