using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using EmployeeManagementSystemApplication.Models;

namespace EmployeeManagementSystemApplication.Controllers
{
    public class RegistrationController : ApiController
    {
        private AppDBContext db = new AppDBContext();
        [HttpGet]
        [Route("api/GetRoleList")]
        public IHttpActionResult GetRoleList()
        {

            IEnumerable<RoleModel> roleList = db.roleModels.ToList();
            if (roleList == null)
            {
                ModelState.AddModelError("", "Unable to retrieved...");

                return NotFound();
            }
            return Ok(roleList);
        }

        // GET: api/GetAllEmployeesRegistration
        [Route("api/Registration")]
        public List<RegistrationModel> GetAllregistrationModels()
        {
            return db.registrationModels.ToList();
        }

        // GET: api/Registration/5
        [ResponseType(typeof(RegistrationModel))]
        [Route("api/GetEmployeeById/{id}")]
        public IHttpActionResult GetRegistrationModel(int id)
        {
            var registrationModel = db.registrationModels.Find(id);
            if (registrationModel == null)
            {
                return NotFound();
            }

            return Ok(registrationModel);
        }

        // PUT: api/Registration/5
        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/UpdateEmployeeByID/{id}")]
        public IHttpActionResult PutRegistrationModel(int id, RegistrationModel registrationModel)
        {
            var studioList = db.studioModels.ToList();
            registrationModel.StudioID = studioList.Where(s => s.StudioName == registrationModel.StudioName).FirstOrDefault().StudioID;
            

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registrationModel.EmployeeID)
            {
                
                return BadRequest();
            }
           
            db.Entry(registrationModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistrationModelExists(id))
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

        // POST: api/Registration
        [ResponseType(typeof(RegistrationModel))]
        [Route("api/RegisterEmployee")]
        public IHttpActionResult PostRegistrationModel(RegistrationModel registrationModel)
        {
            //registrationModel.StudioID = 1;
            var studioList = db.studioModels.ToList();
            registrationModel.StudioID = studioList.Where(s => s.StudioName == registrationModel.StudioName).FirstOrDefault().StudioID;
      
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.registrationModels.Add(registrationModel);
            db.SaveChanges();

          //return CreatedAtRoute("DefaultApi", new { id = registrationModel.EmployeeID }, registrationModel);
            return Ok(registrationModel);
        }

        // DELETE: api/Registration/5
        [ResponseType(typeof(RegistrationModel))]
        [Route("api/DeleteEmployeeById/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteRegistrationModel(int id)
        {
           
            RegistrationModel registrationModel = db.registrationModels.Find(id);
            if (registrationModel == null)
            {
                return NotFound();
            }

            db.registrationModels.Remove(registrationModel);
            db.SaveChanges();

            return Ok(registrationModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegistrationModelExists(int id)
        {
            return db.registrationModels.Count(e => e.EmployeeID == id) > 0;
        }
    }
}