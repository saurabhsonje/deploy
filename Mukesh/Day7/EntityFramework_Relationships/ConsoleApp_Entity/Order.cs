using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Entity
{
   public class Order
    {
        [Key]
        public int Order_ID { get; set; }
        public string Order_Date { get; set; }
        public string Order_Supplier { get; set; }
        public List<Supplier> suppliers { get; set; }
    }
}
