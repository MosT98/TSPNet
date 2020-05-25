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
    public class DetailsModel : PageModel
    {
        private readonly MyPhotosWEB.Data.MyPhotosWEBContext _context;

        public DetailsModel(MyPhotosWEB.Data.MyPhotosWEBContext context)
        {
            _context = context;
        }

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
    }
}
