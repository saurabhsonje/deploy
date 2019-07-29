using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5b
{
    public static class ExtensionClass
    { 

        public static string DisplayDate(this DateTime date, string format)
        {
            switch(format)
            {
                case "1":
                    return string.Format("{0:ddd, dd MMM yyyy}", date);
           
            
                case "2":
                    return string.Format("{0:dddd, dd MMM yyyy}", date);

                case "3" :
                    return string.Format("{0:dd MMM yyyy h:mm tt}", date);

                case "4":
                    return string.Format("{0:dd MMM yyyy HH:mm}", date);

                case "5" :
                    return string.Format("{0:yyyy-MM-dd}", date);

                case "6":
                    return string.Format("{0:yyyy-MM-dd HH:mm:ss}", date);

                case "7":
                    return string.Format("{0:yyyy/MM/dd}", date);

               
                default:
                    return string.Format("{0:dd MMM yyyy}", date);
            }
        }

    }
}
