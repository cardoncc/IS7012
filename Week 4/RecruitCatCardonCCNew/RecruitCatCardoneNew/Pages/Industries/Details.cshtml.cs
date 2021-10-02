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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext _context;

        public DetailsModel(RecruitCatCardoneNew.Data.RecruitCatCardoneNewContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);

            if (Industry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
