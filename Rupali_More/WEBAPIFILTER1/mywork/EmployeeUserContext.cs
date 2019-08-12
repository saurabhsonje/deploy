using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;

namespace WEBAPIFILTER
{
    public class EmployeeUserContext: DbContext
    {
        internal object Users;

        public EmployeeUserContext() : base("MydbConn")
        {
            Database.SetInitializer<EmployeeUserContext>(new CreateDatabaseIfNotExists<EmployeeUserContext>());
        }

        public DbSet<EmployeeTable> employees { get; set; }
        public DbSet<Users> users { get; set; }
    }
}