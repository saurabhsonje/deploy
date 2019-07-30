using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ConsoleApp11
{
    
    public static class dateformat
    {
       
          public static  string dateformat1(this DateTime Date)
         {
            string ConvertedDate = DateTime.Now.ToString("yyyy/MM/dd");

            return ConvertedDate;
         }

     }
}
