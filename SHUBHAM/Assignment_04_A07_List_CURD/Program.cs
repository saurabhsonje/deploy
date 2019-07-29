using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_A07_List_CURD
{

    class Program
    {

        public const string ENTER_CHOICE = "ENTER THE CHOICE";
        public const string ONE_FOR_INSERTION = "ENTER 1 FOR INSERTION ";
        public const string TWO_FOR_INSERTION = "ENTER 2 FOR UPDATION ";
        public const string THREE_FOR_DISPLAY = "ENTER 3 FOR DISPLAY";
        public const string FOUR_FOR_DELETION = "ENTER 4 FOR  DELETION";
        public const string ZERO_FOR_EXIT = "ENTER ZERO FOR EXIT";
        public const string ENTER_ID = "ENTER THE ID OF EMPLOYEE";
        public const string ENTER_NAME = "ENTER NAME OF EMPLOYEE ";
        public const string ALL_EMPLOYEES= "ALL EMPLOYEES ------->";
        public const string LIST_IS_EMPTY = "LIST IS EMPTY---------->";
        public const string EXIT = "EXIT";


        static void Main(string[] args)
        {
            Initialization();
        }



        private static void Initialization()
        {
            int choice = 0;
            List<Employee> EmployeeList = new List<Employee>();

            do
            {

                string[] Menus = { ZERO_FOR_EXIT, ONE_FOR_INSERTION,
                                   TWO_FOR_INSERTION, THREE_FOR_DISPLAY,
                                   FOUR_FOR_DELETION };


                MenuPrinting(ref Menus);
                var choiceAsString = Console.ReadLine();

                while (!int.TryParse(choiceAsString, out choice))
                {
                    Console.WriteLine("CHOICE MUST BE AN INTEGER!");
                    choiceAsString = Console.ReadLine();
                }

                switch (choice)
                {

                    case 1 :
                        Employee Employee = EmployeeUtils.EnterEmployeeDetails();
                        EmployeeUtils.AddEmployee(ref EmployeeList, ref Employee);
                        break;

                    case 2:
                        Operations operations = new Operations();
                        operations.Update(EmployeeUtils.UpdateEmployee(ref EmployeeList));
                        break;

                    case 3:
                        Console.WriteLine(ALL_EMPLOYEES);
                        Operations operation = new Operations();
                        operation.Display(ref EmployeeList);
                        break;


                    case 4:
                        if (EmployeeUtils.EmployeeListCount(ref EmployeeList) == 0)
                            Console.WriteLine(LIST_IS_EMPTY);
                        else
                        {
                            Operations opr = new Operations();
                            opr.Delete(ref EmployeeList);
                        }
                            break;

                    default:
                        Console.WriteLine(EXIT);
                        System.Environment.Exit(0);
                        break;
                }
            } while (choice != 0);

        }


        static void MenuPrinting(ref string[] Menus)
        {
            foreach (var Menu in Menus)
             Console.WriteLine(Menu);
        }
    }
}
