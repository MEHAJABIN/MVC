using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC1.Models
{
    public class MVC1Context : DbContext
    {
        public MVC1Context (DbContextOptions<MVC1Context> options)
            : base(options)
        {
        }

        public DbSet<MVC1.Models.Movie> Movie { get; set; }
    }
}
