using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace HatosAPI.Data
{
    public class HatosAPIContext : DbContext
    {
        public HatosAPIContext (DbContextOptions<HatosAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Jatekos> Jatekos { get; set; } = default!;

        public DbSet<ClassLibrary.Models.Tipp>? Tipp { get; set; }
    }
}
