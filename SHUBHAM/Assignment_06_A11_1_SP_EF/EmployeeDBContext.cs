using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_A11_1_SP_EF
{
    class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() : base("server=.\\SQLEXPRESS;database=DEMO;Trusted_Connection=true")
        {

        }


        public DbSet<Employee> Employee { get; set; }
    }
}
