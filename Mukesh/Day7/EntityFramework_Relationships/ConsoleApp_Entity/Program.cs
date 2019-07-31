using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderContext OC = new OrderContext();
            var ord = new Order() {Order_ID=10, Order_Supplier="Pinkesh",Order_Date="03/25/2019"};
            OC.Orders.Add(ord);
            var sp = new Supplier() {Cust_Name="Mike",Cust_Code=411089,Cust_Adress="Satara", Order_ID=10};
            OC.Suppliers.Add(sp);
            OC.SaveChanges();
            //Another way of creating an object
            var Sp = new Order()
            {
                Order_Supplier = "Jaggy",
                Order_Date = "04/06/2017",

                suppliers = new List<Supplier>()
                {
                    new Supplier()
                    {
                        Cust_Name="sanket", Cust_Adress="Amroli", Cust_Code=876340,

                    }
                }

            };
            OC.Orders.Add(Sp);
            OC.SaveChanges();

            //Extracting name of Suppliers with particular order ID
            var content=OC.Suppliers.Join(OC.Orders, s => s.Order_ID, o => o.Order_ID,(s, o) => new {o.Order_Supplier});
            foreach(var e in content)
            {
                Console.WriteLine(" "+e.Order_Supplier);
            }
            Console.ReadKey();
        }
    }
}
