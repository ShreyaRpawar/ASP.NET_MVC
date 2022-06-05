using EmployeeOnboardingProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnboardingProcess.Services
{
    public class EmployeeService
    {
        private readonly OnboardingEntities1 context;

        public EmployeeService(OnboardingEntities1 context)
        {
            this.context = context;
        }
        public IQueryable<Educationinfo> getEducationInfo()
        {
            var educationinfo = from e in context.Educationinfoes
                                select e;
            return educationinfo;
        }

        public IQueryable<Professionalinfo> getProfessionalInfo()
        {
            var professionalinfo = from p in context.Professionalinfoes
                                   select p;
            return professionalinfo;
        }

        public IQueryable<Personalinfo> getPersonalInfo()
        {
            var personalinfo = from p in context.Personalinfoes
                               select p;
            return personalinfo;
        }


        
    }
}