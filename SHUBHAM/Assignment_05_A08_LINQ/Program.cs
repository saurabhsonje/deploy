using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_A08_LINQ
{

    class Program
    {

        public const string ENTER_ID = "ENTER THE ID OF EMPLOYEE";
        public const string ENTER_NAME = "ENTER NAME OF EMPLOYEE ";
        public static readonly string ENTER_CHOICE = "ENTER THE CHOICE";
        public static readonly string ONE_FOR_INSERTION = "ENTER 1 FOR INSERTION ";
        public static readonly string TWO_FOR_DISPLAY = "ENTER 2 FOR DISPLAY";
        public static readonly string ZERO_FOR_EXIT = "ENTER ZERO FOR EXIT";
        public static readonly string SECOND_HIGHEST = "FIND SECOND HEIGHEST SALARY";


        static void Main(string[] args)
        {
            Initialization();
            Console.ReadLine();
        }

        public static void Initialization()
        {
            int choice = 0;
            List<Employee> employees = new List<Employee>();

            do{

                string[] Menus = { ZERO_FOR_EXIT, ONE_FOR_INSERTION,
                                   TWO_FOR_DISPLAY,
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
                    case 1:
                        Employee emp = EnterEmployeeDetails();
                        employees.Add(emp);

                        break;

                    case 2:
                        foreach (var item in employees)
                            Console.WriteLine(item.ToString());
                        break;

                    case 3:

                        if (employees.Count() != 2) {

                            Console.WriteLine("LIST MUST HAVE MORE THAN ONE ELEMENTS ");
                        } else {

                            Console.WriteLine(SECOND_HIGHEST);
                            var b = employees.OrderByDescending(x => x.Salary).Skip(1).FirstOrDefault();
                            Console.WriteLine(b.ToString());
                        }
                            break;

                    case 4:
                        NthHeighestSalary(ref employees);
                        break;


                    case 5:

                        if (employees.Count() != 2)
                        {
                             Console.WriteLine("LIST MUST HAVE MORE THAN ONE ELEMENTS ");
                        }
                        else
                        {
                           Console.WriteLine(SECOND_HIGHEST);
  
                        }
                        break;

                    default:
                        System.Environment.Exit(0);
                        break;
                }


            } while (choice != 0);

        }



        public static void NthHeighestSalary(ref List<Employee> employees)
        {

            int n = 0;
            Console.WriteLine("Find the N Highest Salary");

            var nInString = Console.ReadLine();

            while (!int.TryParse(nInString, out n))
            {
                Console.WriteLine("Enter The value on n");
                nInString = Console.ReadLine();
            }

            if (n > employees.Count())
                Console.WriteLine("VALUE OF N IS GREATER THAN THE SIZE OF LIST");
            else
            {
                var a = employees.OrderByDescending(x => x.Salary).Select(x => x.Salary).Distinct().Take(n).Skip(n - 1).First();
                Console.WriteLine(a.ToString());
            }
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

            Console.WriteLine("SALARY --->");
            var salaryAsString = Console.ReadLine();
            Double salary = 0;
            while (!Double.TryParse(salaryAsString, out salary))
            {
                Console.WriteLine("SALARY MUST BE NUMBER-----> ");
                salaryAsString = Console.ReadLine();
            }
            Employee employee = new Employee() { Id = Id, Name = name, Salary = salary };
            return employee;
        }
    }
}
