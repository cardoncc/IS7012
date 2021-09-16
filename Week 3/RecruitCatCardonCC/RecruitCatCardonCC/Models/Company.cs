using System;
namespace RecruitCatCardonCC.Models
{
    public class Company
    {
        public Company()
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string PositionHiring { get; set; }
            public int MinSalary { get; set; }
            public int MaxSalary { get; set; }
            public DateTime? PreferredStartDate { get; set; }
            public string Location { get; set; }
            public int? SigningBonus { get; set; }
            public List<Candidate> Candidates { get; set; }
            public Industry Industry { get; set; }
            public int IndustryId { get; set; }
        }
    }
}
