using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApiTodo.Models;

namespace WebApiTodo.Dao
{
    public class TodoDao
    {
        public static List<Todo> todos = new List<Todo>()
        {
            new Todo(1,"Meeting"),
            new Todo(2,"Training")
        };
        public List<Todo> GetTodoList()
        {
            return todos;
        }

        public Todo GetTodoById(int id)
        {
            var todo = todos.FirstOrDefault(x => x.TaskId == id);
            Todo todoById = todo;
            if(todo==null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No id with that task={0}", id)),
                    ReasonPhrase = "Not Found"
                };
                throw new HttpResponseException(resp);

            }
            return todo;
        }

        public void DeleteById(int id)
        {
            var todo = todos.FirstOrDefault(x => x.TaskId == id);
            if (todo == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No id with that task={0}", id)),
                    ReasonPhrase = "Not Found"
                };
                throw new HttpResponseException(resp);

            }
            todos.Remove(todo);
        }

        public void UpdateById(int id,Todo todo)
        {
            todos.FirstOrDefault(x => x.TaskId == id).TaskName=todo.TaskName;
        }

        public void InsertInTodo(Todo todo)
        {
            if (todo == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("No data present in the header")),
                    ReasonPhrase = "Not Found Data in the Header"
                };
                throw new HttpResponseException(resp);

            }
            todos.Add(todo);
        }

    }
}