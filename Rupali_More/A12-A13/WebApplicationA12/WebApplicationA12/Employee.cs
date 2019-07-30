using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationA12
{
    public class Employee
    {
        int Emp_Id;
        String Name;
        string Address;
        int phone_No;
        public Employee(int i,string name,string Addr,int pno)
        {

        }
        public void GetData()
        {
            Console.WriteLine("Enter your id ");
            Emp_Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Name");
           Name = Console.ReadLine();

            Console.WriteLine("Enter your Address ");
            Address = Console.ReadLine();

            Console.WriteLine("Enter your Phone Number ");
            phone_No = int.Parse(Console.ReadLine());
                                                  
        }
    }
}