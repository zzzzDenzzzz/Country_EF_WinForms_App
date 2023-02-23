using Country_EF_WinForms_App.Entities;
using Country_EF_WinForms_App.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Country_EF_WinForms_App.Contexts
{
    public partial class CountryContext : DbContext
    {
        public CountryContext()
        {
        }

        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionHome"].ConnectionString);
                    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CountryEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CityEntityMap).Assembly);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
