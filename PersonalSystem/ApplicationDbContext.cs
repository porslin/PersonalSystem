using Microsoft.EntityFrameworkCore;
using PersonalSystem.Shared;

namespace PersonalSystem
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // Personal
        public virtual DbSet<Personal> Personal { get; set; }

        // Avdelning

        public virtual DbSet<Avdelning> Avdelning { get; set; }
    }
}
