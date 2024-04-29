using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazor8Scaffold;

namespace Blazor8Scaffold.Data
{
    public class Blazor8DbContext : DbContext
    {
        public Blazor8DbContext (DbContextOptions<Blazor8DbContext> options)
            : base(options)
        {
        }

        public DbSet<Blazor8Scaffold.Mammals> Mammals { get; set; } = default!;
    }
}
