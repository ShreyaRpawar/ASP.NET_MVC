//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeOnboardingProcess.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professionalinfo
    {
        public int Professionalid { get; set; }
        public int EmployeeId { get; set; }
        public string WorkExperience { get; set; }
        public string Company { get; set; }
        public string Field_of_Experience { get; set; }
        public string Experties { get; set; }
    
        public virtual Personalinfo Personalinfo { get; set; }
    }
}
