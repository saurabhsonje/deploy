using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    class FileLogger : ILogger
    {
        public void Handle(string error)
        {
           
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
