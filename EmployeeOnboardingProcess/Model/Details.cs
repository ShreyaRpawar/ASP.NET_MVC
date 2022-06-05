using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnboardingProcess.Model
{
    public class Details
    {
        public int EmployeeId { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Local_Address { get; set; }
        public string State_N { get; set; }
        public string City { get; set; }
        public int ContactNo { get; set; }
        public string Emailid { get; set; }
        public string SSC_School_Name { get; set; }
        public Nullable<int> SSC_percentage { get; set; }
        public Nullable<int> SSC_Passing_Year { get; set; }
        public string HSC_College_Name { get; set; }
        public Nullable<int> HSC_percentage { get; set; }
        public Nullable<int> HSC_Passing_Year { get; set; }
        public string Degree_College_Name { get; set; }
        public string Degree { get; set; }
        public int Degree_percentage { get; set; }
        public Nullable<int> Degree_Passing_Year { get; set; }
        public string University { get; set; }
        public string Highest_Qualification { get; set; }
        public string Work_Experience { get; set; }
        public string Company { get; set; }
        public string Field_of_Experience { get; set; }
        public string Experties { get; set; }
    }
}