using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignments
{
    class ExceptionHandling:ApplicationException
    {
        public ExceptionHandling(string message) : base(String.Format("{0}", message))
        {
           
          
        }
    }
}
