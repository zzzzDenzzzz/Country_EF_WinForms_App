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
            builder.HasOne(e => e.Country)
                .WithMany(x => x.Cities)
                .HasForeignKey(e => e.Id)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
