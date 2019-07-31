using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkAssignment2
{
    public class Company
    {
       [Key]
        public int Company_Id { get; set; }
        public string Company_Name { get; set; }
        public string Company_city { get; set; }

        public ICollection<Food> food { get; set; }
    }
}
