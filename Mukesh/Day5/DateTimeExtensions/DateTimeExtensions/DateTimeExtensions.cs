using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExtensions
{
    public static class DateTimeExtensions
    {
        public static string getformatdatetime(this DateTime dt)
        {
            string DateTime = dt.ToString("yyyy MM dd HH mm ss");
            return DateTime;
        }
    }
}
