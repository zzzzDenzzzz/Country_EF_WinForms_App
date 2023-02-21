using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Country_EF_WinForms_App.EntityMappings
{
    internal class CityEntityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name).IsUnique();

            builder.Property(e => e.Name).HasMaxLength(DefaultDB.StringValueMaxLength);

            builder.HasOne(e => e.Country)
                .WithMany(e => e.Cities)
                .HasForeignKey(e => e.CountryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
