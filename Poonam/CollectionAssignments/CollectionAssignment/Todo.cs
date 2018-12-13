using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class Todo
    {
        public string name { set; get; }
        public int priority { set; get; }
        public Todo()
        {

        }
        public Todo(string name,int priority)
        {
            this.name = name;
            this.priority = priority;
        }
    }
}
