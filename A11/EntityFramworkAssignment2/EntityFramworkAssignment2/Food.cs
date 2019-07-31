using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkAssignment2
{
   public class Food
    {
        
        [Key]
        public int Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Unit { get; set; }

        public int Company_Id { get; set; }
        [ForeignKey("Company_Id")]

        public Company company { get; set; }
    }
}
