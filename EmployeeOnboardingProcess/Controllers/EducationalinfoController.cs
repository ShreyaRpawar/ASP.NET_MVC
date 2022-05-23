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
        private OnboardingEntities1 context = new OnboardingEntities1();

        //private OnboardingEntities1 Context;

        //public EducationalinfoController(OnboardingEntities1 Context)
        //{
        //    this.Context = Context;
        //}

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
            Educationinfo empInDb = new Educationinfo();
            empInDb.EmployeeId = educationInformation.EmployeeId;
            empInDb.Educationid = educationInformation.Educationid;
            empInDb.SSC_School_Name = educationInformation.SSC_School_Name;
            empInDb.SSC_percentage = educationInformation.SSC_percentage;
            empInDb.SSC_Passing_Year = educationInformation.SSC_Passing_Year;
            empInDb.HSC_College_Name = educationInformation.HSC_College_Name;
            empInDb.HSC_percentage = educationInformation.HSC_percentage;
            empInDb.HSC_Passing_Year = educationInformation.HSC_Passing_Year;
            empInDb.Degree_College_Name = educationInformation.Degree_College_Name;
            empInDb.Degree_percentage = educationInformation.Degree_percentage;
            empInDb.Degree_Passing_Year = educationInformation.Degree_Passing_Year;
            empInDb.Degree = educationInformation.Degree;
            empInDb.Highest_Qualificaion = educationInformation.Highest_Qualificaion;

            context.Educationinfoes.Add(empInDb);
            context.SaveChanges();

            return RedirectToAction("Create", "Personalinfo");
        }
    }
}