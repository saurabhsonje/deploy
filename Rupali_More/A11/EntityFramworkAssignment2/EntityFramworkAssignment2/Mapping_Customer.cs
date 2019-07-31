using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkAssignment2
{
    public class Mapping_Customer
    {
        public Mapping_Customer()
        {

        }
        [Key]
        public string Item_Name { get; set; }
        public string Company_Name { get; set; }
        public string Company_city{get;set;}

        public Company company { get; set; }
        public Food foods { get; set; }

        public override string ToString()
        {
            return "Item_Name  " +Item_Name+ "\tCompany_Name  "+Company_Name+ " \t Company_city "+Company_city;
        }
    }

}
