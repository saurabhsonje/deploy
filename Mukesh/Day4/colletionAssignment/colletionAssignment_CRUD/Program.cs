using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colletionAssignment_CRUD
{

    class Employee
    {
        public int EID, ESalary;
        public string EName;

        public Employee() { }
        public Employee(int i,string n, int s)
        {
            this.EID = i;
            this.EName = n;
            this.ESalary = s;
        }



        public override string ToString()
        {
            return EID.ToString() + " " + EName + " " + ESalary.ToString();
        }
    }
    class Program
    {

       
        public static  List<Employee> al = new List<Employee>();
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Employee emp = new Employee();
                Console.WriteLine("___________________________");
                Console.WriteLine("1.Create");
                Console.WriteLine("2.Read");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("___________________________");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the ID of employee:");
                        emp.EID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name of employee:");
                        emp.EName = Console.ReadLine();
                        Console.WriteLine("Enter the salary of employee:");
                        emp.ESalary = Convert.ToInt32(Console.ReadLine());
                        al.Add(new Employee (emp.EID, emp.EName, emp.ESalary));
                        break;
                    case 2:
                        foreach(Employee e in al)
                        {
                            Console.WriteLine(" "+e.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the employee you want to update:");
                        string upName = Console.ReadLine();
                        Console.WriteLine("Enter the new value of salary:");
                        int upSal = Convert.ToInt16(Console.ReadLine());
                        var dName = al.Find(x => x.EName == upName);
                        if (dName.EName == upName)
                        {
                            dName.ESalary = upSal;
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter the name to delete:");
                        string strName = Console.ReadLine();
                        var delName = al.Where(x => x.EName == strName).FirstOrDefault();
                        al.Remove(delName);
                        break;
                    case 5:
                        break;

                }

            } while (choice != 0);

        }
    }
}
