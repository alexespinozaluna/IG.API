using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class tdHTMLConfiguration : IEntityTypeConfiguration<tdHTML>
    {
        public void Configure(EntityTypeBuilder<tdHTML> builder)
        {
            builder.HasKey(p => p.IdtdHTML);
            builder.Property(p => p.TipoHTML).HasMaxLength(100);
            builder.Property(p => p.HTML).HasMaxLength(int.MaxValue);
            builder.Property(e => e.IdtdHTML).ValueGeneratedNever();

        }
    }
}
