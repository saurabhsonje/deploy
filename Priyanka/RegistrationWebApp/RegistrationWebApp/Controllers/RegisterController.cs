using RegistrationWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationWebApp.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RegistrationForm()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Display()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RegistrationForm(Register register)
        {

            if (ModelState.IsValid)
            {

                return View("Display", register);

            }
            else
            {

                return View();

            }

        }
    }
}