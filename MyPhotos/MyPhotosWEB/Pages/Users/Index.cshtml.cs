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
    public class IndexModel : PageModel
    {
        private readonly MyPhotosWEB.Data.MyPhotosWEBContext _context;

        public IndexModel(MyPhotosWEB.Data.MyPhotosWEBContext context)
        {
            _context = context;
        }

        public IList<UserDTO> UserDTO { get;set; }

        public async Task OnGetAsync()
        {
            UserDTO = await _context.UserDTO.ToListAsync();
        }
    }
}
