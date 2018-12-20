using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTodo.Models
{
    public class Todo
    {
        public int TaskId { set; get; }
        public string TaskName { set; get; }
        public Todo(int TaskId,string TaskName)
        {
            this.TaskId = TaskId;
            this.TaskName = TaskName;
        }
    }
}