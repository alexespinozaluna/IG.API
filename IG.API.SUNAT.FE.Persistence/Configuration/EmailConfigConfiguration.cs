using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class EmailConfigConfiguration : IEntityTypeConfiguration<EmailConfig>
    {
        public void Configure(EntityTypeBuilder<EmailConfig> builder)
        {
            builder.Property(P => P.Host).HasMaxLength(100);
            builder.Property(P => P.Email).HasMaxLength(200);
            builder.Property(P => P.Password).HasMaxLength(500);
            builder.Property(P => P.DisplayName).HasMaxLength(250);


            builder.HasOne(e => e.Empresa)
           .WithMany(e => e.Emails)
           .HasForeignKey(e => e.IdEmpresa)
           .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
