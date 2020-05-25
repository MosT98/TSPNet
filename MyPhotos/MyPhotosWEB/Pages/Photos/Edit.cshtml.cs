using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPhotosWEB.Data;
using MyPhotosWEB.Models;

namespace MyPhotosWEB.Pages.Photos
{
    public class EditModel : PageModel
    {
        private readonly MyPhotosWEB.Data.MyPhotosWEBContext _context;

        public EditModel(MyPhotosWEB.Data.MyPhotosWEBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PhotoDTO PhotoDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PhotoDTO = await _context.PhotoDTO.FirstOrDefaultAsync(m => m.PhotoId == id);

            if (PhotoDTO == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PhotoDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoDTOExists(PhotoDTO.PhotoId))
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

        private bool PhotoDTOExists(Guid id)
        {
            return _context.PhotoDTO.Any(e => e.PhotoId == id);
        }
    }
}
