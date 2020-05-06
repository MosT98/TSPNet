using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Halauca_Andrei_Rp.Model;

namespace Asp_Halauca_Andrei_Rp.Data
{
    public class Asp_Halauca_Andrei_RpContext : DbContext
    {
        public Asp_Halauca_Andrei_RpContext (DbContextOptions<Asp_Halauca_Andrei_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Halauca_Andrei_Rp.Model.Movie> Movie { get; set; }
    }
}
