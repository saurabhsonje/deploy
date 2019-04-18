using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EmployeeManagementSystemApplication.Models;

namespace EmployeeManagementSystemApplication.Controllers
{
    public class AdminController : ApiController
    {
        private AppDBContext db = new AppDBContext();

        // GET: api/Admin
        [Route("api/GetList")]
        public IHttpActionResult GetList()
        {

            IEnumerable<StudioModel> list = db.studioModels.ToList();
            if (list == null)
            {
                ModelState.AddModelError("", "Unable to retrieved...");

                return NotFound();
            }
            return Ok(list);
        }

        [Route("api/GetStudioList")]
        public List<StudioModel> GetStudioList()
        {
            return db.studioModels.ToList();
        }

        // GET: api/Admin/5
        [ResponseType(typeof(StudioModel))]
        [Route("api/GetStudioByID/{id}")]
        public IHttpActionResult GetStudioModel(int id)
        {
            StudioModel studioModel = db.studioModels.Find(id);
            if (studioModel == null)
            {
                return NotFound();
            }

            return Ok(studioModel);
        }

        // PUT: api/Admin/5
        [HttpPut]
        [ResponseType(typeof(void))]
        [Route("api/UpdateStudioByID/{id}")]
        public IHttpActionResult PutStudioModel(int id, StudioModel studioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studioModel.StudioID)
            {
                return BadRequest();
            }

            db.Entry(studioModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudioModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Admin
        [HttpPost]
        [ResponseType(typeof(StudioModel))]
        [Route("api/AddStudio")]
        public IHttpActionResult PostStudioModel(StudioModel studioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.studioModels.Add(studioModel);
            db.SaveChanges();

            //return CreatedAtRoute("DefaultApi", new { id = studioModel.StudioID }, studioModel);
            return Ok(studioModel);
        }


        // DELETE: api/Admin/5
        
        [ResponseType(typeof(StudioModel))]
        [Route("api/DeleteStudio/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteStudioModel(int id)
        {
            StudioModel studio = db.studioModels.Find(id);
            if (studio != null)
            {
                db.studioModels.Remove(studio);
                db.SaveChanges();
                return Ok(studio);
            }
            else
            {
                return NotFound();
            }
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudioModelExists(int id)
        {
            return db.studioModels.Count(e => e.StudioID == id) > 0;
        }
    }
}