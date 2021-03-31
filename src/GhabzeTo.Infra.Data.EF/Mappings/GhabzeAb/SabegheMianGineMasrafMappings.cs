using GhabzeTo.Domain.Models.GhabzeAb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GhabzeTo.Infra.Data.EF.Mappings
{
    public class SabegheMianGineMasrafMappings : IEntityTypeConfiguration<SabegheMianGineMasraf>
    {
        public void Configure(EntityTypeBuilder<SabegheMianGineMasraf> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.GhabzeAb)
                .WithMany(x => x.SabegheMianGineMasrafs)
                .HasForeignKey(x => x.GhabzeAbId);
        }
    }
}
