using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Entity
{
    //DbContext:all the work to interract with database retrive,update...,populate custome objects
    public class OrderContext:DbContext
    {      

        public OrderContext():base("MydbConn") {
            Database.SetInitializer<OrderContext>(new CreateDatabaseIfNotExists<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        //    modelbuilder.entity<order>().maptostoredprocedures();
        //    modelbuilder.entity<supplier>().maptostoredprocedures();
        //    onmodelcreating(modelbuilder);
        }
    }
}
