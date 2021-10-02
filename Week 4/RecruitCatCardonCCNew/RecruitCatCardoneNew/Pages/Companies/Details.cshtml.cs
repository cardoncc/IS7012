using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatCardoneNew.Data;
using RecruitCatCardoneNew.Models;

namespace RecruitCatCardoneNew.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext _context;

        public DetailsModel(RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company.Include(comp => comp.Candidates)
                .Include(c => c.Industry).FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
