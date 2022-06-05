using EmployeeOnboardingProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOnboardingProcess.Controllers
{
    public class ProfessionalInfoController : Controller
    {
        private readonly OnboardingEntities1 context;

        public ProfessionalInfoController(OnboardingEntities1 context)
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
        public ActionResult Create(Professionalinfo professionalinfo)
        {
            try
            {    
                    Personalinfo personalinfo1 = TempData["Personalinfo"] as Personalinfo;
                    var employeeId = personalinfo1.EmployeeId;
                    professionalinfo.EmployeeId = employeeId;

                    context.Professionalinfoes.Add(professionalinfo);
                    context.SaveChanges();
                    return RedirectToAction("UploadFile", "FileUpload");
            }
            catch (Exception )
            {
                ModelState.AddModelError(" ", "Unable to save changes, try again or contact coditas@gmail.com");
            }

            return View(professionalinfo);
        }
    }
}