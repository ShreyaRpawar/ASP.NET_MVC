using EmployeeOnboardingProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnboardingProcess.Services
{
    public class PersonalService
    {
        private OnboardingEntities1 Context;

        public List<Personalinfo> GetPersonalInformation()
        {
            using (var context = new OnboardingEntities1())
            {
                var result = context.Personalinfoes
                    .Select(x => new Personalinfo()
                    {
                        EmployeeId = x.EmployeeId,
                        Fullname = x.Fullname,
                        Gender = x.Gender,
                        Locality_Address = x.Locality_Address,
                        State_N = x.State_N,
                        City = x.City,
                        Contactno = x.Contactno,
                        Emailid = x.Emailid,
                        Passportfilepath = x.Passportfilepath,
                        Signaturefilepath = x.Signaturefilepath,
                        SSCfilepath = x.SSCfilepath,
                        HSCfilepath = x.HSCfilepath,
                        Degreefilepath = x.Degreefilepath,
                        Adharcardfilepath = x.Adharcardfilepath,
                        Resumefilepath = x.Resumefilepath,
                    }).ToList();
                return result;
            }

        }


    }
}