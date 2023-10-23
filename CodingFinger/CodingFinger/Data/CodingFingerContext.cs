using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodingFinger.Models;

namespace CodingFinger.Data
{
    public class CodingFingerContext : DbContext
    {
        public CodingFingerContext (DbContextOptions<CodingFingerContext> options)
            : base(options)
        {
        }

        public DbSet<CodingFinger.Models.Employer> Employer { get; set; } = default!;
    }
}
