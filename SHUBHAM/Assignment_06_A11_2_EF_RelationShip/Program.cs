using Assignment_06_A11_1_SP_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_A11_2_EF_RelationShip
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBContext db = new EmployeeDBContext();


            Employee employee = new Employee();
            employee.Id = 1;
            employee.FName = "ABC";
            employee.LName = "KK";

            Address address = new Address();
            address.Id = 3;
            address.Location = "LKO";
            address.EmpId = 1;

            db.Employee.Add(employee);
            db.Address.Add(address);

            db.SaveChanges();

             var d =    db.Employee.Join(
                                     db.Address,
                                      e => e.Id,
                                    a => a.EmpId,
                                    (e,a) => new {  FirstName = e.FName,
                                                    LastName = e.LName,
                                                    Add = a.Location
                                                 }
                ).ToList();


           



            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
        }


   

    }
}
