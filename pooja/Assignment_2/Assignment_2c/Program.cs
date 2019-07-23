using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2c
{


    class Generic_Program<T>
    {
        public List<T> _List = new List<T>();

        public static void Print(List<Employee> pList, string info)
        {
            try
            {
                Console.WriteLine(info);

                pList.ForEach(delegate (Employee per)
                {
                    Console.WriteLine(Convert.ToString(per.ID) + "  " + per.FirstName + "  " + per.MiddleName + "  " + per.LastName);
                });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            Console.ReadLine();

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Type :List
            Generic_Program<Employee> Employee = new Generic_Program<Employee>();
            Employee._List.Add(new Employee(1, "Pooja", "A", "yerva"));
            Employee._List.Add(new Employee(2, "Rupali", "A", "More"));
            Employee._List.Add(new Employee(3, "Shubham", "A", "Yadav"));
            Employee._List.Add(new Employee(4, "Mukesh", "A", "Jha"));


            Generic_Program<Employee>.Print(Employee._List, "Display all items in the List");

            //Add Employee 
            Generic_Program<Employee> newList = new Generic_Program<Employee>();
            Employee._List.Add(new Employee(5, "ABC", "B", "DEF"));
            Employee._List.Add(new Employee(6, "XYZ", "B", "PQR"));
            Employee._List.AddRange(newList._List);

            Generic_Program<Employee>.Print(Employee._List, "Add new List<T> to existing List");


            //Delete Employee 
            //  Generic_Program<Employee> removeListItem = new Generic_Program<Employee>();
            Employee._List.RemoveAt(1);

            Generic_Program<Employee>.Print(Employee._List, "Remove multiple items from List<> based on condition ");

        }

    }


}



