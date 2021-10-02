using System;
using System.Collections.Generic;

namespace RecruitCatCardoneNew.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public bool FullTime { get; set; }
        public List<Candidate> Candidates { get; set; }

    }
}
