using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIAssignment.Controllers;

namespace WebAPIAssignment
{
    public class EmpList
    {

        List<Employees> emp = new List<Employees>();
        public void GetAll()
        {
            Console.WriteLine("Enter the name:");
            string LName=Console.ReadLine();
            Console.WriteLine("Enter the ID:");
            int LID =Convert.ToInt16(Console.ReadLine());

            emp.Add(new Employees { ID = LID, Name = LName });

            ValuesController vc = new ValuesController();
            vc.Get();
        }
}
}