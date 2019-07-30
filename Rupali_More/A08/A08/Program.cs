using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A08

{
    class Test
    {
        public delegate void SecondMaxSalary1(List<Employee> Employees);

        public void AddDataInList(List<Employee> Employees)
        {
            Employee employeese = new Employee();

            employeese.GetData();
            Employees.Add(employeese);
            Employees.Add(new Employee("Nilesh", 2, 23400));
            Employees.Add(new Employee("Pooja", 4, 20000));
            Employees.Add(new Employee("Ganesh", 5, 234432));
            Employees.Add(new Employee("mukesh", 6, 27860));
        }
        public void Display(List<Employee> Employees)
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee);
            }
        }
        public static void SecondHighSalary(List<Employee> Employees)
        {
            double largestNo = int.MinValue;
            double secondhighNo = int.MinValue;
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].emp_salary > largestNo)
                {
                    secondhighNo = largestNo;
                    largestNo = Employees[i].emp_salary;

                }
                else if (Employees[i].emp_salary > secondhighNo)
                {
                    secondhighNo = Employees[i].emp_salary;
                }
            }
            Console.WriteLine("second highest number is:{0}", secondhighNo);

        }
        public void SecondHighEmployeeSalaryLambda(List<Employee> Employees)
        {
            var v = Employees.OrderByDescending(x => x.emp_salary).Skip(1).First();
            Console.WriteLine(v);
        }
        public void SecondHighEmployeeSalaryLinQ(List<Employee> Employees)
        {
            var Result_ = (from employee in Employees
                           orderby employee.emp_salary descending
                           select employee).Distinct().Skip(1).First();

            Console.WriteLine(Result_);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int caseuse;
            string Continue;
            List<Employee> Employees = new List<Employee>();
            Test test = new Test();
            test.AddDataInList(Employees);
            test.Display(Employees);

            do
            {
                Console.WriteLine("1.Second Max salary using delegates\n2.Second Max Salary using Lambda\n3.Second Max Salary using Linq");
                caseuse = int.Parse(Console.ReadLine());
                switch (caseuse)
                {
                    case 1:
                        Test.SecondMaxSalary1 maxsalary = new Test.SecondMaxSalary1(Test.SecondHighSalary);
                        maxsalary(Employees);
                        break;
                    case 2:
                        test.SecondHighEmployeeSalaryLambda(Employees);
                        break;
                    case 3:
                        test.SecondHighEmployeeSalaryLinQ(Employees);
                        break;
                }
                Console.Write("Do You Want To Continue? (Y/N) : ");
                Continue = Console.ReadLine();

            } while (Continue != "N" && Continue != "n");
            Console.ReadLine();
        }
    }
}
