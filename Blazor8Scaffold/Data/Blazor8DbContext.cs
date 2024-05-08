using Microsoft.EntityFrameworkCore;
using Blazor8Scaffold.Entities;

namespace Blazor8Scaffold.Data
{
    public class Blazor8DbContext : DbContext
    {
        public Blazor8DbContext (DbContextOptions<Blazor8DbContext> options)
            : base(options)
        {
        }

        public DbSet<Mammal> Mammals { get; set; } = default!;
    }
}
