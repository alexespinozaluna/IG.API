using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class SUNAT_FE_ComprobantConfiguration : IEntityTypeConfiguration<SUNAT_FE_Comprobante>
    {
        public void Configure(EntityTypeBuilder<SUNAT_FE_Comprobante> builder)
        {
            builder.Property(p => p.nomArchivo).HasMaxLength(150);
            builder.Property(p => p.xmlFirmado).HasMaxLength(int.MaxValue);
            builder.Property(p => p.Codigo).HasMaxLength(20);
            builder.Property(p => p.Mensaje).HasMaxLength(int.MaxValue);
            builder.Property(p => p.Descripcion).HasMaxLength(500);
            builder.Property(p => p.Observacion).HasMaxLength(int.MaxValue);
            builder.Property(p => p.Ticket).HasMaxLength(100);
            builder.Property(p => p.dtFechaHoraProceso).HasColumnType("datetime");
            builder.Property(p => p.XmlCdr).HasMaxLength(int.MaxValue);
            builder.Property(p => p.URLDocumento).HasMaxLength(int.MaxValue);
        }
    }
}
