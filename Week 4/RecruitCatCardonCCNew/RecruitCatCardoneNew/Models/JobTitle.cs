using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatCardoneNew.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Job Title")]
        public string Title { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(1, 999999)]
        public int MinSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(1, 999999)]
        public int MaxSalary { get; set; }

        [DisplayName("Full Time?")]
        public bool FullTime { get; set; }

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }

    }
}
