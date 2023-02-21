using Country_EF_WinForms_App.Constants;
using Country_EF_WinForms_App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Country_EF_WinForms_App.EntityMappings
{
    public class CountryEntityMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name).IsUnique();

            builder.Property(e => e.Name).HasMaxLength(DefaultDB.StringValueMaxLength);

            builder.HasOne(e => e.Capital)
                .WithOne()
                .HasForeignKey<Country>(e => e.CapitalId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
