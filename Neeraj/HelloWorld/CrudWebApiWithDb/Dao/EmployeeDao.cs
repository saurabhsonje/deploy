using EmployeeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudWebApiWithDb.Dao
{
    public class EmployeeDao
    {
        public List<tblEmployee> EmployeeListFromDb()
        {
            using (EmployeeEntities employeeEntities = new EmployeeEntities())
            {

                try
                {
                    List<tblEmployee> employeeList = employeeEntities.tblEmployees.ToList();

                    return employeeList;

                }
                catch (ArgumentNullException e)
                {
                    return null;
                }


            }

        }


        public bool AddingEmployeeIntoDb(tblEmployee employeetoBeAdded)
        {
            using (EmployeeEntities employeeEntities = new EmployeeEntities())
            {

                try
                {
                    if (employeetoBeAdded != null)
                    {
                        employeeEntities.tblEmployees.Add(employeetoBeAdded);
                        employeeEntities.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception e)
                {
                    return false;
                }


            }

        }

        public bool EditingEmployeeinDb(int id, tblEmployee employee)
        {
            try
            {
                using (EmployeeEntities employeeEntities = new EmployeeEntities())
                {

                    tblEmployee employeeFromQuery = employeeEntities.tblEmployees.Where(e => e.Id == id).FirstOrDefault();

                    if (employeeFromQuery == null)
                    {
                        return false;
                       // return Request.CreateErrorResponse(HttpStatusCode.NotFound, new ArgumentNullException());
                    }
                    else
                    {
                        employeeFromQuery.Name = employee.Name;
                        employeeFromQuery.Salary = employee.Salary;
                        employeeFromQuery.Dept = employee.Dept;
                        employeeEntities.SaveChanges();
                        return true;
                      //  return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
            }
            catch (Exception e)
            {
                return false;
                //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }


        }





    }
}