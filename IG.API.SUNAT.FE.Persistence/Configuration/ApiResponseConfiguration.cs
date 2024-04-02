using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class ApiResponseConfiguration : IEntityTypeConfiguration<ApiResponse>
    {
        public void Configure(EntityTypeBuilder<ApiResponse> builder)
        {
            builder.Property(p => p.FileName)
                  .HasMaxLength(250);

        }
    }
}
