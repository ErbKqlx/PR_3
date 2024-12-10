using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace PR_3
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TypesOfProducts> TypesOfProducts { get; set; } = null!;
        public DbSet<TypesOfPartners> TypesOfPartners { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Partners;Username=postgres;Password=1111");
        }
    }
}
