using EmployeeManagementSystemApplication.Models;
using System.Web.Http;
using System.Web.Http.Description;

namespace EmployeeManagementSystemApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        AppDBContext appDBContext = new AppDBContext();

        
        [ResponseType(typeof(RegistrationModel))]
        [Route("api/GetEmployeeByEmail/{email}")]
        [HttpGet]
        public IHttpActionResult GetEmployeeByEmail(string email)
        {
            
            RegistrationModel registrationModel = appDBContext.registrationModels.Find(email);
            if (registrationModel == null)
            {
                return NotFound();
            }

            return Ok(registrationModel);
        }

        [HttpGet]
        //[ResponseType(typeof(StudioModel))]
        [Route("api/GetStudioByName/{id}")]
        public IHttpActionResult GetStudioByName(int id)
        {
            StudioModel studioModel = appDBContext.studioModels.Find(id);
            if (studioModel == null)
            {
                return NotFound();
            }

            return Ok(studioModel);
        }
    }
}
