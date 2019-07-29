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
