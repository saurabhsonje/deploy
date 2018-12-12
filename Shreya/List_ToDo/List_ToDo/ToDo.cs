using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ToDo
{
    class ToDo
    {
        public int Priority { get; set; }
        public string Task { get; set; }

        public ToDo(string Task , int Priority)
        {
            this.Priority = Priority;
            this.Task = Task;
        }
    }
}
