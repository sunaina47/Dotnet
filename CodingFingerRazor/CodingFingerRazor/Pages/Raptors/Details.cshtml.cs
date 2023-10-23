using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodingFingerRazor.Data;
using CodingFingerRazor.Models;

namespace CodingFingerRazor.Pages.Raptors
{
    public class DetailsModel : PageModel
    {
        private readonly CodingFingerRazor.Data.CodingFingerRazorContext _context;

        public DetailsModel(CodingFingerRazor.Data.CodingFingerRazorContext context)
        {
            _context = context;
        }

      public Employer Employer { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employer == null)
            {
                return NotFound();
            }

            var employer = await _context.Employer.FirstOrDefaultAsync(m => m.ID == id);
            if (employer == null)
            {
                return NotFound();
            }
            else 
            {
                Employer = employer;
            }
            return Page();
        }
    }
}
