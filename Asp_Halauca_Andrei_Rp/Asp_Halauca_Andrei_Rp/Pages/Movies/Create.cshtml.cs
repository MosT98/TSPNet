﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Asp_Halauca_Andrei_Rp.Data;
using Asp_Halauca_Andrei_Rp.Model;

namespace Asp_Halauca_Andrei_Rp.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Asp_Halauca_Andrei_Rp.Data.Asp_Halauca_Andrei_RpContext _context;

        public CreateModel(Asp_Halauca_Andrei_Rp.Data.Asp_Halauca_Andrei_RpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
