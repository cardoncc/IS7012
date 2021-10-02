using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatCardoneNew.Data;
using RecruitCatCardoneNew.Models;

namespace RecruitCatCardoneNew.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext _context;

        public IndexModel(RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
