using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiEmployee.Dao
{
    interface IEmployeeDao
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        bool AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        void UpdateEmployee(int id, Employee employee);
    }
}
