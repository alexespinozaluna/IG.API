

using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class MaeEmpresaConfiguration : IEntityTypeConfiguration<maeEmpresa>
    {

        public void Configure(EntityTypeBuilder<maeEmpresa> builder)
        {
            builder.HasKey(p => p.IdmaeEmpresa);
            builder.Property(p => p.NommaeEmpresa).HasMaxLength(250);
            builder.Property(p => p.nvNumDocumentoIdentidad).HasMaxLength(15);
            builder.Property(p => p.nvCodTipoDocumentoIdentidad).HasMaxLength(1);
            builder.Property(p => p.nvEncoding).HasMaxLength(50);
            builder.Property(p => p.ntCertificadoPfx).HasMaxLength(int.MaxValue);
            builder.Property(p => p.nvCertificadoPass).HasMaxLength(150);
            builder.Property(p => p.nvURLFE).HasMaxLength(500);
            builder.Property(p => p.nvUsuarioFE).HasMaxLength(250);
            builder.Property(p => p.nvClaveFE).HasMaxLength(250);
            builder.Property(p => p.nvProveedorFE).HasMaxLength(100);
            builder.Property(p => p.ntSoapFE).HasMaxLength(int.MaxValue);
            builder.Property(p => p.nvScopeApiFE).HasMaxLength(250);
            builder.Property(p => p.nvClientIdApiFE).HasMaxLength(500);
            builder.Property(p => p.nvClientSecretApiFE).HasMaxLength(500);
            builder.Property(p => p.nvURLTokenApiFE).HasMaxLength(500);
            builder.Property(p => p.nvURLEnvioApiFE).HasMaxLength(500);
            builder.Property(p => p.nvURLConsultaApiFE).HasMaxLength(500);
            builder.Property(p => p.nvURLFECDR).HasMaxLength(500);
            builder.Property(p => p.imLogo).HasColumnType("image");
            // builder.HasIndex(e => new { e.nvNumDocumentoIdentidad, e.bProduccion }).IsUnique();

            builder.HasOne(e => e.Token)
           .WithOne(ee => ee.Empresa)
           .HasForeignKey<OauthAccessToken>(ee => ee.IdmaeEmpresa)
           .OnDelete(DeleteBehavior.Restrict)
           ;

            builder.HasOne(e => e.Usuario)
        .WithOne(ee => ee.Empresa)
        .HasForeignKey<SistemaUsuario>(ee => ee.IdEmpresa)
        .OnDelete(DeleteBehavior.Restrict)
        ;
            builder.HasMany(e => e.Emails)
        .WithOne(e => e.Empresa)
        .HasForeignKey(ee => ee.IdEmpresa)
        .OnDelete(DeleteBehavior.Restrict)
        ;

        }
    }
}
