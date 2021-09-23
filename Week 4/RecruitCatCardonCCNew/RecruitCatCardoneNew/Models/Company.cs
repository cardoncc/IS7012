using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatCardoneNew.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Company Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Position Hiring")]
        public string PositionHiring { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(1, 999999)]
        public int? MinSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(1, 999999)]
        public int? MaxSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Preferred Start Date")]
        public DateTime? PreferredStartDate { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        [StringLength(200)]
        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("Signing Bonus")]
        [Range(1, 999999)]
        public int? SigningBonus { get; set; }

        [DisplayName("Candidate")]
        public List<Candidate> Candidates { get; set; }

        [DisplayName("Industry")]
        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }

    }
}
