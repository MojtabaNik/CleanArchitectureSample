using GhabzeTo.Domain.Models.GhabzeAb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GhabzeTo.Infra.Data.EF.Mappings
{
    public class GhabzeAbMappings : IEntityTypeConfiguration<GhabzeAb>
    {
        public void Configure(EntityTypeBuilder<GhabzeAb> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.SabegheMianGineMasrafs)
                .WithOne(x => x.GhabzeAb)
                .HasForeignKey(x => x.GhabzeAbId);
        }
    }
}
