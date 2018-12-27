using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.DAO
{
    public class EmployeeDao
    {
        EmployeeDbEntities2 db = new EmployeeDbEntities2();
        public bool AddEmployee(EmployeeInformation employee)
        {
            try
            {
                if (db.StudioInformations.Any(x => x.EmpStudio == employee.EmpStudio))
                {
                    db.EmployeeInformations.Add(employee);
                    db.SaveChanges();
                    return true;

                }
                else
                {
                    return false;
                }


                
            }
            catch (Exception e)
            {
                
                throw new Exception("There was a problem saving this record: " + e.Message);
            }

        }
        public List<EmployeeInformation> GetEmployees()
        {
            return db.EmployeeInformations.ToList();
        }


        public EmployeeInformation GetSingleEmployee()
        {
            using (EmployeeDbEntities2 db1 = new EmployeeDbEntities2())
            {
                db1.EmployeeInformations.Any()


            }

        }
    }
}