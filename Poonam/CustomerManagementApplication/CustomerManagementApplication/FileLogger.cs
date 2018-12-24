using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApplication
{
    class FileLogger : ILogger
    {
        public void handle(string error)
        {
         System.IO.File.WriteAllText(@"c:\Error\Error.txt", error);
        }
    }
}
