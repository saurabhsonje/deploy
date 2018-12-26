using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDao
{
   public interface IEmployeeDao
    {
        List<Employee> GetEmployees();
    }
}
