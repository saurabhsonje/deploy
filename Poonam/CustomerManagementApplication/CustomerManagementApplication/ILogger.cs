using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApplication
{
    interface ILogger
    {
        void handle(string error);
    }
}
