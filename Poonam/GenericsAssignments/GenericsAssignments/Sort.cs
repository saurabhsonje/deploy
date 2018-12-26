using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignments
{
    class Sort<T> where T : IGetValue
    {
        public void sortMethod(List<T> data)
        {
             data.Sort();
        }

    }
}
