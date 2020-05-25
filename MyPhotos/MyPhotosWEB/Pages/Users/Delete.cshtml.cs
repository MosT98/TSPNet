using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhotosWEB.Data;
using MyPhotosWEB.Models;

namespace MyPhotosWEB.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly MyPhotosWEB.Data.MyPhotosWEBContext _context;

        public DeleteModel(MyPhotosWEB.Data.MyPhotosWEBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserDTO UserDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserDTO = await _context.UserDTO.FirstOrDefaultAsync(m => m.UserId == id);

            if (UserDTO == null)
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

            UserDTO = await _context.UserDTO.FindAsync(id);

            if (UserDTO != null)
            {
                _context.UserDTO.Remove(UserDTO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
