using EmployeeOnboardingProcess.Models;
using EmployeeOnboardingProcess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOnboardingProcess.Controllers
{
    public class PersonalinfoController : Controller
    {
        private OnboardingEntities1 Context ;

        public PersonalinfoController(OnboardingEntities1 Context)
        {
            Context = new OnboardingEntities1();
        }

        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Personalinfo personalInformation)
        {
            if (personalInformation.EmployeeId == 0)
                Context.Personalinfoes.Add(personalInformation);
            else
            {
                var employeeInDb = Context.Personalinfoes.Single(c => c.EmployeeId == personalInformation.EmployeeId);
                employeeInDb.Fullname = personalInformation.Fullname;
                employeeInDb.Gender = personalInformation.Gender;
                employeeInDb.Locality_Address = personalInformation.Locality_Address;
                employeeInDb.State_N = personalInformation.State_N;
                employeeInDb.City = personalInformation.City;
                employeeInDb.Contactno = personalInformation.Contactno;
                employeeInDb.Emailid = personalInformation.Emailid;
                employeeInDb.Passportfilepath = personalInformation.Passportfilepath;
                employeeInDb.Signaturefilepath = personalInformation.Signaturefilepath;
                employeeInDb.Adharcardfilepath = personalInformation.Adharcardfilepath;
                employeeInDb.SSCfilepath = personalInformation.SSCfilepath;
                employeeInDb.HSCfilepath = personalInformation.HSCfilepath;
                employeeInDb.Degreefilepath = personalInformation.Degreefilepath;
                employeeInDb.Resumefilepath = personalInformation.Resumefilepath;

            }

            Context.SaveChanges();

            return RedirectToAction("Create", "Educationinfo");
        }

    }
}