using EmployeeOnboardingProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOnboardingProcess.Controllers
{
    public class PersonalInfoController : Controller
    {
        private readonly OnboardingEntities1 context;

        public PersonalInfoController(OnboardingEntities1 context )
        {
            this.context = context;
        }

        // GET: PersonalInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Personalinfo personalinfo)
        {
            try
            {
                    context.Personalinfoes.Add(personalinfo);
                    context.SaveChanges();
                    TempData["Personalinfo"] = personalinfo;
                    return RedirectToAction("Create", "Educationalinfo");
                
            }
            catch (Exception )
            {
                ModelState.AddModelError(" ", "Unable to save changes, try again or contact coditas@gmail.com");
            }

            return View(personalinfo);
        }
    }
}