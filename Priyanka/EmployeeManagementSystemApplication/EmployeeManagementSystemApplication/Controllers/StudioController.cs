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
    public class StudioController : ApiController
    {
        private AppDBContext db = new AppDBContext();
       
        [HttpGet]
        [Route("api/Studio/GetStudioList")]
        public IHttpActionResult GetStudioList()
        {
            IEnumerable<StudioModel> studios = db.studioModels.ToList();
            if (studios == null)
            {
                ModelState.AddModelError("", "Studio not Retrieved Successfully");
                return NotFound();
                //ModelState.AddModelError("","Studio Retrieved...")

            }

            return Ok(studios);

        }
    }
}