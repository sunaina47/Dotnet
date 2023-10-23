using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodingFingerRazor.Data;
using CodingFingerRazor.Models;

namespace CodingFingerRazor.Pages.Raptors
{
    public class EditModel : PageModel
    {
        private readonly CodingFingerRazor.Data.CodingFingerRazorContext _context;

        public EditModel(CodingFingerRazor.Data.CodingFingerRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employer Employer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employer == null)
            {
                return NotFound();
            }

            var employer =  await _context.Employer.FirstOrDefaultAsync(m => m.ID == id);
            if (employer == null)
            {
                return NotFound();
            }
            Employer = employer;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployerExists(Employer.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployerExists(int id)
        {
          return (_context.Employer?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
