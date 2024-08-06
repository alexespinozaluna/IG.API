using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class SistemaUsuarioConfiguration : IEntityTypeConfiguration<SistemaUsuario>
    {
      
        public void Configure(EntityTypeBuilder<SistemaUsuario> builder)
        {
            builder.HasKey(p => p.IdSistemaUsuario);
            builder.Property(P => P.CodSistemaUsuario).HasMaxLength(50);
            builder.Property(P => P.NomSistemaUsuario).HasMaxLength(150);
            builder.Property(P => P.PassUsuario).HasMaxLength(250);

            builder.HasIndex(p => p.CodSistemaUsuario).IsUnique();



        }
    }
}
