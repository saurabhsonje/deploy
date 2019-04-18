using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassExample
{
    class Employee<T1,T2>
    {
        public Employee(T1 id,T2 name)
        {
            Console.WriteLine("ID is : "+id);
            Console.WriteLine("Name is : "+ name);
           
        }
    }
    class Generic
    {
        static void Main()
        {
            Employee<int,string> emp1 = new Employee<int,string>(1,"Priyanka");
            Employee<int, string> emp2 = new Employee<int, string>(2, "Thakur");
            Console.ReadLine();
        }
    }
}
