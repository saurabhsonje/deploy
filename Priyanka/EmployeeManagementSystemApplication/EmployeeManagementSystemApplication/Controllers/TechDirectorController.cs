using EmployeeManagementSystemApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity.Infrastructure;

using System.Web.Http.Description;


namespace EmployeeManagementSystemApplication.Controllers
{
    public class TechDirectorController : ApiController
    {
        private AppDBContext db = new AppDBContext();
       
        [Route("api/GetEmployees")]
        public List<RegistrationModel> GetEmployees()
        {
            return db.registrationModels.Where(s=>s.StudioName.Equals("Talent Pool")).ToList();
        }
       

        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/TechDirector/EditEmployee/{id}")]
        public IHttpActionResult EditEmployee(int id, RegistrationModel registrationModel)
        {
            var studioList = db.studioModels.ToList();
            registrationModel.StudioID = studioList.Where(s => s.StudioName == registrationModel.StudioName).FirstOrDefault().StudioID;
            

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != registrationModel.EmployeeID)
            //{
            //    return BadRequest();
            //}

            //var empList = db.registrationModels.ToList();
            //RegistrationModel model = db.registrationModels.Find(registrationModel.EmployeeID);
            //registrationModel.EmailID = empList.Where(s => s.UserName == model.UserName).FirstOrDefault().EmailID;
            

            var employee = db.registrationModels.Where(x => x.EmployeeID.Equals(id)).FirstOrDefault();
            employee.StudioID = registrationModel.StudioID;
            employee.StudioName = registrationModel.StudioName;
            //db.Entry(employee).State = EntityState.Modified;
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

        private bool RegistrationModelExists(int id)
        {
            return db.registrationModels.Count(e => e.EmployeeID == id) > 0;
        }
    }
}
