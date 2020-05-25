using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPhotosWEB.Models;

namespace MyPhotosWEB.Data
{
    public class MyPhotosWEBContext : DbContext
    {
        public MyPhotosWEBContext (DbContextOptions<MyPhotosWEBContext> options)
            : base(options)
        {
        }

        public DbSet<MyPhotosWEB.Models.PhotoDTO> PhotoDTO { get; set; }

        public DbSet<MyPhotosWEB.Models.UserDTO> UserDTO { get; set; }

        public DbSet<MyPhotosWEB.Models.FolderDTO> FolderDTO { get; set; }
    }
}
