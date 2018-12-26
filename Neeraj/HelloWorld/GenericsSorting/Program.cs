using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSorting
{
    class Program
    {

        static void Main(string[] args)
        {
 
            List<Employee> empList = new List<Employee>();
            Employee e1 = new Employee(1, "neeraj", 19);
            empList.Add(e1);
            Employee e2 = new Employee(2, "akash", 21);
            empList.Add(e2);
            Employee e3 = new Employee(4, "anirudh", 20);
            empList.Add(e3);
            Employee e4 = new Employee(3, "anirudh", 16);
            //empList.Add(e4);

            Sort<Employee> sortObj = new Sort<Employee>(); 
            sortObj.sorts(empList);


            // listofEmployees();

            foreach (Employee e in empList)
            {
               
                Console.WriteLine("id:{0} name:{1} age:{2}", e.id,e.name,e.age);
            }



            Console.ReadKey();


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        
    }


}
