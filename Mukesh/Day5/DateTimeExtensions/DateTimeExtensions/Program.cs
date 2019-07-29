using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeExtensions;


namespace DateTimeFormating
{
    class Program
    {
        static void Main(string[] args)
        {
            //gives current date-Time in format 25/07/2019 03:31:06
            DateTime DT = DateTime.Now;
            Console.WriteLine("Formatted DateTime is:" + DT.getformatdatetime());
            
            Console.ReadKey();
        }
    }
}
