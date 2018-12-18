using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudAPI.Models;

namespace CrudAPI.Controllers
{
    public class ValuesController : ApiController
    {
        
        public HttpResponseMessage Post([FromBody] ToDo toDo)
        {
            try
            {
                if (toDo != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, toDo);
                }
                else
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Todo is empty(null)");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }


        }

        public IHttpActionResult Get()
        {
            List<ToDo> toDoList = new List<ToDo>()
                    {
                        new ToDo(1,1,"meeting"),
                        new ToDo(2,3,"lunch"),
                        new ToDo(3,2,"client call")


                    };

            return Ok(toDoList); // returns Ok() status with a response body which contains toDoList
                                 // return Ok();  // simply returns Ok() status and nothing in response body
        }


  /*      public List<ToDo> CreateList()
        {
            List<ToDo> toDoList = new List<ToDo>()
                    {
                        new ToDo(1,1,"meeting"),
                        new ToDo(2,3,"lunch"),
                        new ToDo(3,2,"client call")


                    };

            return toDoList; 
        } */


        [Route("api/values/{id}/{priority}")]
        public HttpResponseMessage Put(int id, int priority, [FromBody] string task)
        {
            //  List<ToDo> toDoList = CreateList();
            List<ToDo> toDoList = new List<ToDo>()
                    {
                        new ToDo(1,1,"meeting"),
                        new ToDo(2,3,"lunch"),
                        new ToDo(3,2,"client call")


                    };


            var item = toDoList.Where(t => t.id == id).FirstOrDefault();
            item.priority = priority;
            item.task = task;

            return Request.CreateResponse(HttpStatusCode.OK, toDoList);

        }
        public HttpResponseMessage Delete(int id)
        {
            //  List<ToDo> toDoList = CreateList();
            List<ToDo> toDoList = new List<ToDo>()
                    {
                        new ToDo(1,1,"meeting"),
                        new ToDo(2,3,"lunch"),
                        new ToDo(3,2,"client call")


                    };



            var item = toDoList.Where(t => t.id == id).FirstOrDefault();

            toDoList.Remove(item);

            return Request.CreateResponse(HttpStatusCode.OK, toDoList);

        }

        //experiments *******************************************************************************************************

          
          // works - http://localhost:64859/api/values?pri=2
 /*     public HttpResponseMessage Delete(int pri)
      {
          List<ToDo> toDoList = CreateList();

          var item = toDoList.Where(t => t.priority == pri).FirstOrDefault();

          toDoList.Remove(item);

          return Request.CreateResponse(HttpStatusCode.OK, toDoList);

      }
          public void Get(int name)
                  {

                  }

        
      // works with request: http://localhost:64859/api/values?priority=1&id=1

      public void Get(int priority, int id)
              {

              }
        
              //something i tried for knowledge and it works
              //extra
              [Route("api/values/{priority}")]
              public HttpResponseMessage Put(int priority, [FromBody] string task)
              {
                  List<ToDo> toDoList = CreateList();

                  var item = toDoList.Where(t => t.priority == priority).FirstOrDefault();
                  //  item.priority = priority;
                  item.task = task;

                  return Request.CreateResponse(HttpStatusCode.OK, toDoList);

              }

              // *************

*/

    }
}
