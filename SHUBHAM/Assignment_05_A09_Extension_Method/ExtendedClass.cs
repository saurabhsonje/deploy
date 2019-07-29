using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_A09_Extension_Method
{
    public static class ExtendedClass
    {

        public static string[] FilterDate(this string k)
        {

            string[] vs = null;
            if (k.Contains("-") || k.Contains("/"))
                vs = k.Split('-', '/');
            return vs;
        }

        public static void DateInDDMMYYYYFormat(this string st, ref string[] vs)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(vs[0]);
            sb.Append("-");
            sb.Append(vs[1]);
            sb.Append("-");
            sb.Append(vs[2]);


            Console.WriteLine("<--- DATE IN DD-MM-YYYY --->");
            Console.WriteLine("<---" + sb.ToString() + "-->");

        }

        public static void DateInMMDDYYFormat(this string st, ref string[] vs)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(vs[1]);
            sb.Append("-");
            sb.Append(vs[0]);
            sb.Append("-");
            sb.Append(vs[2]);


            Console.WriteLine("<--- DATE IN MM-DD-YYYY --->");
            Console.WriteLine("<---" + sb.ToString() + "--->");


        }


        public static void DateInYYMMDDFormat(this string st, ref string[] vs)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(vs[2]);
            sb.Append("-");
            sb.Append(vs[1]);
            sb.Append("-");
            sb.Append(vs[0]);


            Console.WriteLine("<-- DATE IN YYYY-MM-DD -->");
            Console.WriteLine("<--" + sb.ToString() + "-->");


        }
    }

}
