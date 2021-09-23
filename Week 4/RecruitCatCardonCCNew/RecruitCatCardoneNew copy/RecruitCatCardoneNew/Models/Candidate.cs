using System;
using System.Collections.Generic;

namespace RecruitCatCardoneNew.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TargetSalary { get; set; }
        public DateTime? PreferredStartDate { get; set; }
        public bool OpenToInternship { get; set; }
        public string Degree { get; set; }
        public int YearsOfExperience { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

    }
}
