using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class OauthAccessTokenConfiguration : IEntityTypeConfiguration<OauthAccessToken>
    {
        public void Configure(EntityTypeBuilder<OauthAccessToken> builder)
        {
            //builder.Property(p => p.ruc).HasMaxLength(15);
            builder.Property(p => p.access_token).HasMaxLength(int.MaxValue);
            builder.Property(p => p.token_type).HasMaxLength(150);
            builder.Property(p => p.username).HasMaxLength(150);
            builder.Property(p => p.date_expires_in).HasColumnType("datetime");

       

        }
    }
}
