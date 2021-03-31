using GhabzeTo.Domain.Models.GhabzeBargh;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GhabzeTo.Infra.Data.EF.Mappings
{
    public class GhabzeBarghMappings : IEntityTypeConfiguration<GhabzeBargh>
    {
        public void Configure(EntityTypeBuilder<GhabzeBargh> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
