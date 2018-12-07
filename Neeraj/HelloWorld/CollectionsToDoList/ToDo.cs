using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsToDoList
{
    class ToDo
    {
        public string task { get; set; }
        public int priority { get; set; }

        public ToDo(string task,int priority)
        {
            this.priority = priority;
            this.task = task;
        }

    }
}
