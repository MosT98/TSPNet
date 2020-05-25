using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhotosWEB.Data;
using MyPhotosWEB.Models;

namespace MyPhotosWEB.Pages.Photos
{
    public class DeleteModel : PageModel
    {
        private readonly MyPhotosWEB.Data.MyPhotosWEBContext _context;

        public DeleteModel(MyPhotosWEB.Data.MyPhotosWEBContext context)
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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PhotoDTO = await _context.PhotoDTO.FindAsync(id);

            if (PhotoDTO != null)
            {
                _context.PhotoDTO.Remove(PhotoDTO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
