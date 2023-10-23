using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodingFingerRazor.Models;

namespace CodingFingerRazor.Data
{
    public class CodingFingerRazorContext : DbContext
    {
        public CodingFingerRazorContext (DbContextOptions<CodingFingerRazorContext> options)
            : base(options)
        {
        }

        public DbSet<CodingFingerRazor.Models.Employer> Employer { get; set; } = default!;
    }
}
