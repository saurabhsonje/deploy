using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class HandlingException:ApplicationException
    {
        public HandlingException(string message) : base(String.Format("{0}", message))
        {


        }
    }
}
