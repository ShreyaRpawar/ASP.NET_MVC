using EmployeeOnboardingProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOnboardingProcess.Controllers
{
    public class EducationalinfoController : Controller
    {

        private OnboardingEntities1 Context;

        public EducationalinfoController(OnboardingEntities1 Context)
        {
            this.Context = Context;
        }

        // GET: Educationalinfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Educationinfo educationInformation)
        {
            Context.Educationinfoes.Add(educationInformation);
            Context.SaveChanges();

            return RedirectToAction("Create", "Personalinfo");
        }
    }
}