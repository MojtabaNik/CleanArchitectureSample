using GhabzeTo.Domain.Models.GhabzeTelephone;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GhabzeTo.Infra.Data.EF.Mappings
{
    public class GhabzeTelephoneMappings : IEntityTypeConfiguration<GhabzeTelephone>
    {
        public void Configure(EntityTypeBuilder<GhabzeTelephone> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
