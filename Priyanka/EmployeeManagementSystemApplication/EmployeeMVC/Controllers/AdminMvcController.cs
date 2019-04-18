using EmployeeManagementSystemApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class AdminMvcController : Controller
    {
        static string URL = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
        AppDBContext appDBContext = new AppDBContext();

        static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(URL)
        };
        // GET: AdminMvc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStudioList()
        {
            List<StudioModel> studioList = null;
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetStudioList").Result;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    studioList = httpResponseMessage.Content.ReadAsAsync<List<StudioModel>>().Result;
                    return View(studioList);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Get Information of All Employees...");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }


            return View();
        }

        public ActionResult GetStudioByID(int id)
        {
            HttpResponseMessage httpResponseMessage = client.GetAsync($"api/GetStudioByID/{id}").Result;
            StudioModel studioModel = null;
            try
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    studioModel = httpResponseMessage.Content.ReadAsAsync<StudioModel>().Result;
                    return View(studioModel);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Get Studio...");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);

            }
            return View();
        }

        [HttpGet]
        public ActionResult UpdateStudio(int id)
        {

            try
            {
                HttpResponseMessage studioDetailsResponse = client.GetAsync($"api/GetStudioByID/{id}").Result;
               

                if (studioDetailsResponse.IsSuccessStatusCode)
                {
                    StudioModel studioModels = studioDetailsResponse.Content.ReadAsAsync<StudioModel>().Result;
                    
                    return View(studioModels);
                }

                else
                {
                   
                    return View();
                }



            }
            catch (Exception exe)
            {
                ModelState.AddModelError("", exe.Message);
                return View();

            }
        }
        [HttpPost]
        public ActionResult UpdateStudio(StudioModel studioModel)
        {
            try
            {


                HttpResponseMessage studioUpdateResponse = client.PutAsJsonAsync("api/UpdateStudioByID/" + studioModel.StudioID, studioModel).Result;

                if (studioUpdateResponse.IsSuccessStatusCode)
                {

                    return RedirectToAction("GetStudioList");
                }
                else
                {
                    ModelState.AddModelError("", "Studio could not be edited");
                    return View(studioModel);
                }


            }
            catch (Exception exe)
            {
                ModelState.AddModelError("", exe.Message);
                return View(studioModel);
            }
        }
        [HttpGet]
        public ActionResult AddStudio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudio(StudioModel studioModel)
        {
        
            HttpResponseMessage createdStudioResponse = client.PostAsJsonAsync("api/AddStudio", studioModel).Result;
            
            if (createdStudioResponse.IsSuccessStatusCode)
            {
                
                StudioModel studio = createdStudioResponse.Content.ReadAsAsync<StudioModel>().Result;
                return RedirectToAction("GetStudioList");
            }
            else
            {

                ModelState.AddModelError("", "Studio could not be created");
                return View();
            }

        }
       
      
        public ActionResult DeleteStudio(int id)
        {
            try
            {
                HttpResponseMessage deleteStudioResponse = client.DeleteAsync($"api/DeleteStudio/{id}").Result;
                StudioModel studio = null;



                if (deleteStudioResponse.IsSuccessStatusCode)
                {
                    studio = deleteStudioResponse.Content.ReadAsAsync<StudioModel>().Result;

                    return View(studio);
                }
                else
                {
                    ModelState.AddModelError("", "Unable to Delete Studio...");
                    //return RedirectToAction("GetStudioList");
                }
            }
            catch (Exception exe)
            {
                ModelState.AddModelError("", exe.Message);
                

            }
            return RedirectToAction("GetStudioList");
        }

    }
}