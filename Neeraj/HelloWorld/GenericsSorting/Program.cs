using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSorting
{
    class Program
    {
        //private const int V = 23;

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Console.WriteLine("Hello World!");
            List<Employee> empList = new List<Employee>();
            Employee e1 = new Employee(1, "neeraj", 22);
            empList.Add(e1);
            Employee e2 = new Employee(2, "akash", 21);
            empList.Add(e1);
            Employee e3 = new Employee(3, "anirudh", 20);
            empList.Add(e1);

        //    int a = e1.GetValue();
            List<string> nameList = new List<string>();
            nameList.Add("ne");
            nameList.Add("er");
            nameList.Add("jk");

            List<int> numberList = new List<int>();
            numberList.Add(22);
            numberList.Add(21);
            numberList.Add(38);


          //  Sort<T> sortss = new Sort<T>();









            Console.ReadKey();


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }


}
