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
    public class IndexModel : PageModel
    {
        private readonly CodingFingerRazor.Data.CodingFingerRazorContext _context;

        public IndexModel(CodingFingerRazor.Data.CodingFingerRazorContext context)
        {
            _context = context;
        }

        public IList<Employer> Employer { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } 
        public async Task OnGetAsync()
        {
                var pos = from m in _context.Employer
                    select m;

                if (!string.IsNullOrEmpty(SearchString))
                {
                    pos = pos.Where(s => s.EmployerDesignation.Contains(SearchString));
                }
                Employer = await pos.ToListAsync();
               // Employer = await _context.Employer.ToListAsync();
            }
    }
}
