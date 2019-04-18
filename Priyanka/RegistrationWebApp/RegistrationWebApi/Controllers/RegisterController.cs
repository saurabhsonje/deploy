
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
using RegistrationDAL.Model;
using ServiceLayer;

namespace RegistrationWebApi.Controllers
{
    public class RegisterController : ApiController
    {
        private AppDbContext db = new AppDbContext();

        RegistrationService registrationService = new RegistrationService();
        // GET: api/Register
        [HttpGet]
        [Route("api/GetAllEmployee")]
        public List<Register> GetregisterModel()
        {
            return db.registerModel.ToList();
        }

        // GET: api/Register/5

        [ResponseType(typeof(Register))]
        [Route("api/GetEmployeeById/{id}")]
        public IHttpActionResult GetRegister(int id)
        {
            Register register = registrationService.GetEmployeeById(id);
            if (register == null)
            {
                return NotFound();
            }

            return Ok(register);
        }

        // PUT: api/Register/5
        [HttpPut]
        [ResponseType(typeof(void))]
        [Route("api/UpdateEmployeeByID/{id}")]
        public IHttpActionResult PutRegister(int id, Register register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != register.empId)
            {
                return BadRequest();
            }

            db.Entry(register).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterExists(id))
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

        // POST: api/Register
        [ResponseType(typeof(Register))]
        [Route("api/RegisterEmployee")]
        public IHttpActionResult PostRegister(Register register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.registerModel.Add(register);
            db.SaveChanges();

            //return CreatedAtRoute("DefaultApi", new { id = register.empId }, register);
            return Ok(register);
        }

        // DELETE: api/Register/5
        [HttpDelete]
        [ResponseType(typeof(Register))]
        [Route("api/DeleteEmployeeById/{id}")]
        public IHttpActionResult DeleteRegister(int id)
        {
            Register register = db.registerModel.Find(id);
            if (register == null)
            {
                return NotFound();
            }

            db.registerModel.Remove(register);
            db.SaveChanges();

            return Ok(register);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegisterExists(int id)
        {
            return db.registerModel.Count(e => e.empId == id) > 0;
        }
    }
}