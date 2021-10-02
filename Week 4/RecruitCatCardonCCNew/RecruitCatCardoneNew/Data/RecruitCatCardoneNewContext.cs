using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatCardoneNew.Models;

namespace RecruitCatCardoneNew.Data
{
    public class RecruitCatCardoneNewContext : DbContext
    {
        public RecruitCatCardoneNewContext (DbContextOptions<RecruitCatCardoneNewContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatCardoneNew.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatCardoneNew.Models.Company> Company { get; set; }

        public DbSet<RecruitCatCardoneNew.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatCardoneNew.Models.JobTitle> JobTitle { get; set; }
    }
}
