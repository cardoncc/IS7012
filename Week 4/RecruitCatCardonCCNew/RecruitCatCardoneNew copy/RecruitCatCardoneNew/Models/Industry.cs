using System;
using System.Collections.Generic;

namespace RecruitCatCardoneNew.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MarketCap { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }

    }
}
