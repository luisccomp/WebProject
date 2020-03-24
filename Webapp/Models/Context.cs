using Microsoft.EntityFrameworkCore;

namespace Webapp.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)       
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=webprojectdb;Pooling=true;User Id=dbadmin;Password=12345");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("products");
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
    }
}