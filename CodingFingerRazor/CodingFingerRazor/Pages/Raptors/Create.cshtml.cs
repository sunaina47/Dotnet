﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CodingFingerRazor.Data;
using CodingFingerRazor.Models;

namespace CodingFingerRazor.Pages.Raptors
{
    public class CreateModel : PageModel
    {
        private readonly CodingFingerRazor.Data.CodingFingerRazorContext _context;

        public CreateModel(CodingFingerRazor.Data.CodingFingerRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employer Employer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Employer == null || Employer == null)
            {
                return Page();
            }

            _context.Employer.Add(Employer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
