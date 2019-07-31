using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Entity
{
    public class Supplier
    {
        [Key]
        public int Cust_ID { get; set; }
        public string Cust_Name { get; set; }
        public string Cust_Adress { get; set; }
        public int Cust_Code { get; set; }

       
        public int Order_ID { get; set; }
        [ForeignKey("Order_ID")]
        public virtual Order order { get; set; }
    }

}
