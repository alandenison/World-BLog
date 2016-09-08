using Microsoft.EntityFrameworkCore;

namespace WorldBlog.Models
{
    public class WorldBlogContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Person> Persons { get; set; }

        public WorldBlogContext(DbContextOptions<WorldBlogContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}