using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RocinanteUniversity.Models;

namespace RocinanteUniversity.Data
{
    public class RocinanteUniversityContext : DbContext
    {
        public RocinanteUniversityContext (DbContextOptions<RocinanteUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<RocinanteUniversity.Models.Student> Student { get; set; }
    }
}
