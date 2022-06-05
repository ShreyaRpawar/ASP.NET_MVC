using EmployeeOnboardingProcess.Models;
using EmployeeOnboardingProcess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOnboardingProcess.Controllers
{
    public class EducationalInfoController : Controller
    {
        // GET: EducationalInfo

        private readonly OnboardingEntities1 context;


        public EducationalInfoController(OnboardingEntities1 context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Educationinfo educationalinfo, Personalinfo personalinfo)
        {
            try
            {
                    Personalinfo personalinfo1 = TempData["Personalinfo"] as Personalinfo;
                    var employeeId = personalinfo1.EmployeeId;
                    educationalinfo.EmployeeId = employeeId;

                    context.Educationinfoes.Add(educationalinfo);
                    context.SaveChanges();
                    return RedirectToAction("Create", "ProfessionalInfo");
                
            }

            catch (Exception )
            {
                ModelState.AddModelError(" ", "Unable to save changes, try again or contact coditas@gmail.com");
            }
            return View(educationalinfo);
        }
    }
}