using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSorting
{
    class Sort<T> where T : IValue
    {
        public void sorts(List<T> dataList)
        {
            dataList.Sort();

        }

    }
}
