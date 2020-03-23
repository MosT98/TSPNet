using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCodeFirst.Data
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Proiect;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(User.Create("Andrei", "Halauca", "ahalauca@gmail.com", "parola123"));
            modelBuilder.Entity<Photo>()
                .HasData(Photo.Create("Poza1", "Brasov", "E:\\IMPORTANT\\pozamunte.jpg"));
        }
    }
}
