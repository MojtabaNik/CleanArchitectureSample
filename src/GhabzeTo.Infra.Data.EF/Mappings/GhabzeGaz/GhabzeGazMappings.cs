using GhabzeTo.Domain.Models.GhabzeGaz;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GhabzeTo.Infra.Data.EF.Mappings
{
    public class GhabzeGazMappings : IEntityTypeConfiguration<GhabzeGaz>
    {
        public void Configure(EntityTypeBuilder<GhabzeGaz> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
