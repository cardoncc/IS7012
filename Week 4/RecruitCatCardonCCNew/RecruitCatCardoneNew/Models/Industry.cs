using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatCardoneNew.Models
{
    public class Industry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Industry")]
        public string Name { get; set; }

        [Range(1,9999)]
        [DisplayName("Market Capitalization (in Billions)")]
        public int? MarketCap { get; set; }

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }

        [DisplayName("Companies")]
        public List<Company> Companies { get; set; }

    }
}
