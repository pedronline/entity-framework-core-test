using Microsoft.EntityFrameworkCore;

namespace entity_framework_core_test.Entities
{
    class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ActorDb;" + "Trusted_Connection=True;");
        }
    }
}
