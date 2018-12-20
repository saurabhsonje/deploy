using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTodo.Dao;
using WebApiTodo.Models;

namespace WebApiTodo.Controllers
{
    public class TodoController : ApiController
    {
        TodoDao dao = new TodoDao();
      
        public List<Todo> GetAllTodos()
        {
            return dao.GetTodoList();
        }

        public Todo Get(int id)
        {
           return dao.GetTodoById(id);
        }

        public void Post([FromBody]Todo todo)
        {
            dao.InsertInTodo(todo);
        }

        public void Put(int id, [FromBody]Todo todo)
        {
         dao.UpdateById(id, todo);
        }
       
        public void Delete(int id)
        {
            dao.DeleteById(id);
        }
    }
}
