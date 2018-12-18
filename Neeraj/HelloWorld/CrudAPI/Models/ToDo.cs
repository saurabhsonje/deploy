using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAPI.Models
{
    public class ToDo
    {
        public int id { get; set; }
        public int priority { get; set; }
        public string task { get; set; }

        public ToDo(int id,int priority,string task)
        {
            this.id = id;
            this.priority = priority;
            this.task = task;
        }

    }
}