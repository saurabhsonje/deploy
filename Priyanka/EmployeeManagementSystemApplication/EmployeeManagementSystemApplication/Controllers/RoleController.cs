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
    public class RoleController : ApiController
    {
        private AppDBContext db = new AppDBContext();


       

        // GET: api/Role
        public IQueryable<RoleModel> GetroleModels()
        {
            return db.roleModels;
        }

        // GET: api/Role/5
        [ResponseType(typeof(RoleModel))]
        public IHttpActionResult GetRoleModel(int id)
        {
            RoleModel roleModel = db.roleModels.Find(id);
            if (roleModel == null)
            {
                return NotFound();
            }

            return Ok(roleModel);
        }

        // PUT: api/Role/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRoleModel(int id, RoleModel roleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != roleModel.RoleID)
            {
                return BadRequest();
            }

            db.Entry(roleModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleModelExists(id))
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

        // POST: api/Role
        [ResponseType(typeof(RoleModel))]
        public IHttpActionResult PostRoleModel(RoleModel roleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.roleModels.Add(roleModel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = roleModel.RoleID }, roleModel);
        }

        // DELETE: api/Role/5
        [ResponseType(typeof(RoleModel))]
        public IHttpActionResult DeleteRoleModel(int id)
        {
            RoleModel roleModel = db.roleModels.Find(id);
            if (roleModel == null)
            {
                return NotFound();
            }

            db.roleModels.Remove(roleModel);
            db.SaveChanges();

            return Ok(roleModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RoleModelExists(int id)
        {
            return db.roleModels.Count(e => e.RoleID == id) > 0;
        }
    }
}