using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOnboardingProcess.Controllers
{
    public class ProfessionalinfoController : Controller
    {
        private OnboardingEntities1 Context;

        public ProfessionalinfoController(OnboardingEntities1 Context)
        {
            this.Context = Context;
        }
        // GET: Professionalinfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Educationinfo EducationInformation)
        {
            Context.Educationinfoes.Add(EducationInformation);
            Context.SaveChanges();

            return RedirectToAction("FileUpload ", "FileUpload");

        }
    }
}