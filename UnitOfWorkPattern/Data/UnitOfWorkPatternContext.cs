using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkPattern.Models;

namespace UnitOfWorkPattern.Data
{
    public class UnitOfWorkPatternContext : DbContext
    {
        public UnitOfWorkPatternContext (DbContextOptions<UnitOfWorkPatternContext> options)
            : base(options)
        {
        }

        public DbSet<UnitOfWorkPattern.Models.Product> Product { get; set; } = default!;
    }
}
