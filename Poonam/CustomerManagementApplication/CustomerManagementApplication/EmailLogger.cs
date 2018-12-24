using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApplication
{
    class EmailLogger : ILogger
    {
        public void handle(string error)
        {
            Console.WriteLine("Error Logged By mail");
        }
    }
}
