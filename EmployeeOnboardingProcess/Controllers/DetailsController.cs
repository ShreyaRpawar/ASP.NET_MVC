using EmployeeOnboardingProcess.Model;
using EmployeeOnboardingProcess.Models;
using EmployeeOnboardingProcess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOnboardingProcess.Controllers
{
    public class DetailsController : Controller
    {
        private readonly EmployeeService employeeservice;
        private readonly OnboardingEntities1 context;

        public DetailsController(EmployeeService employeeservice , OnboardingEntities1 context)
        {
            this.employeeservice = employeeservice;
            this.context = context;
        }
        public ActionResult Index()
        {
           var personalinfo = employeeservice.getPersonalInfo();
           var professionalinfo = employeeservice.getProfessionalInfo();


            var information = from p in personalinfo
                          join r in professionalinfo on
                          p.EmployeeId equals r.EmployeeId
                          select new
                          {
                              EmployeeId = p.EmployeeId,
                              Fullname = p.Fullname,
                              Field_of_Experience = r.Field_of_Experience,
                              Company = r.Company

                          };

            List<profile> profile = new List<profile>();
            foreach (var p in information)
            {
               
                profile.Add(new profile()
                {
                    EmployeeId = p.EmployeeId,
                    Fullname = p.Fullname,
                    Field_of_Experience = p.Field_of_Experience,
                    Company = p.Company

                }) ;
            }
            return View(profile);

        }

        public ActionResult Details(int id)
        {
            Details detail = new Details();
            var personalinfo = context.Personalinfoes.FirstOrDefault(x => x.EmployeeId == id);
            var educationalinfo = context.Educationinfoes.FirstOrDefault(x => x.Educationid == id);
            var professionalinfo = context.Professionalinfoes.FirstOrDefault( x => x.Professionalid == id);

            detail.EmployeeId = personalinfo.EmployeeId;
            detail.Fullname = personalinfo.Fullname;
            detail.Gender = personalinfo.Gender;
            detail.Local_Address = personalinfo.Locality_Address;
            detail.State_N = personalinfo.State_N;
            detail.City = personalinfo.City;
            detail.ContactNo = personalinfo.Contactno;
            detail.SSC_School_Name = educationalinfo.SSC_School_Name;
            detail.SSC_percentage = educationalinfo.SSC_percentage;
            detail.SSC_Passing_Year = educationalinfo.SSC_Passing_Year;
            detail.HSC_College_Name = educationalinfo.HSC_College_Name;
            detail.HSC_percentage = educationalinfo.HSC_percentage;
            detail.HSC_Passing_Year = educationalinfo.HSC_Passing_Year;
            detail.Degree = educationalinfo.Degree;
            detail.Degree_College_Name = educationalinfo.Degree;
            detail.Degree_percentage = educationalinfo.Degree_percentage;
            detail.Degree_Passing_Year = educationalinfo.Degree_Passing_Year;
            detail.University = educationalinfo.University;
            detail.Highest_Qualification = educationalinfo.Highest_Qualificaion;
            detail.Company = professionalinfo.Company;
            detail.Work_Experience = professionalinfo.WorkExperience;
            detail.Field_of_Experience = professionalinfo.Field_of_Experience;
            detail.Experties = professionalinfo.Experties;

            return View(detail);

        }


        //public ActionResult Details()
        //{

        //    var personalinfo = employeeservice.getPersonalInfo();
        //    var educationinfo = employeeservice.getEducationInfo();
        //    var professionalinfo = employeeservice.getProfessionalInfo();

        //    var employeeDatails = from p in personalinfo
        //                          join e in educationinfo on p.EmployeeId equals e.EmployeeId into table1
        //                          from e in table1.ToList()
        //                          join r in professionalinfo on e.Educationid equals r.Professionalid into table2
        //                          from r in table2.ToList()
        //                          select new
        //                          {
        //                              EmployeeId = p.EmployeeId,
        //                              FullName = p.Fullname,
        //                              Gender = p.Gender,
        //                              Local_Address = p.Locality_Address,
        //                              State_N = p.State_N,
        //                              City = p.City,
        //                              ContactNo = p.Contactno,
        //                              SSC_School_Name = e.SSC_School_Name,
        //                              SSC_Percentage = e.SSC_percentage,
        //                              SSC_Passing_Year = e.SSC_Passing_Year,
        //                              HSC_College_Name = e.HSC_College_Name,
        //                              HSC_Percentage = e.HSC_percentage,
        //                              HSC_Passing_Year = e.HSC_Passing_Year,
        //                              Degree = e.Degree,
        //                              Degree_College_Name = e.Degree_College_Name,
        //                              Degree_Percentage = e.Degree_percentage,
        //                              Degree_Passing_Year = e.Degree_Passing_Year,
        //                              University = e.University,
        //                              Highest_Qualification = e.Highest_Qualificaion,
        //                              Work_Experience = r.WorkExperience,
        //                              Company = r.Company,
        //                              Field_of_Experience = r.Field_of_Experience,
        //                              Experties = r.Experties,
        //                          };

         
       

    }
}

