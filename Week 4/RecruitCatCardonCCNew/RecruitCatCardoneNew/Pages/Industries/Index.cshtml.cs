using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatCardoneNew.Data;
using RecruitCatCardoneNew.Models;

namespace RecruitCatCardoneNew.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext _context;

        public IndexModel(RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
