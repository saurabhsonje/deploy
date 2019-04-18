using Employee.Data.ModelEntities;
using EmployeeManagementSystemApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EmployeeManagementSystemApplication.Controllers
{
    public class MainCommonController : ApiController
    {
        AppDBContext appDBContext = new AppDBContext();

        //[ResponseType(typeof(RegistrationModel))]\ 
        [HttpGet]
        [Route("api/GetByEmail/{EmailID}")]
        public IHttpActionResult GetEmployeeByEmail(string email)
        {
            var registrationModel = appDBContext.registrationModels.Find(email);
            if (registrationModel == null)
            {
                return NotFound();
            }

            return Ok(registrationModel);
        }

        [HttpPost]
        [Route("api/Login")]
          public IHttpActionResult Login(LoginModel loginModel)
          {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Unable to Login");
                return BadRequest();
            }

            RegistrationModel employee = appDBContext.registrationModels.Where(s => s.EmailID.Equals(loginModel.EmailID)).FirstOrDefault();

            if(employee.EmailID.Equals(loginModel.EmailID) && employee.Password.Equals(loginModel.Password))
            {
                ModelState.AddModelError("","Login Successful");
                return Ok(employee);

            }
            else
            {
                ModelState.AddModelError("", "Oops..!! Unable to Login.");
                return BadRequest();
            }
          }




        /// <summary>
        /// This function will give studio by name
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Studio model</returns>
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
