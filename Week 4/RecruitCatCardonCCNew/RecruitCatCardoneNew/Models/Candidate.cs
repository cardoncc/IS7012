using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatCardoneNew.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range(1, 999999)]
        [DisplayName("Target Salary")]
        public int? TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Preferred Start Date")]
        public DateTime? PreferredStartDate { get; set; }

        [DisplayName("Open to Internship?")]
        public bool OpenToInternship { get; set; }

        [DisplayName("Degree")]
        [StringLength(100)]
        public string Degree { get; set; }

        [DisplayName("Years of Experience")]
        [Range(0, 99)]
        public int YearsOfExperience { get; set; }

        [DisplayName("Company")]
        public Company Company { get; set; }

        [DisplayName("Company")]
        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }

        [DisplayName("Industry")]
        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }


        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
