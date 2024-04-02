using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class APIEndPointConfiguration : IEntityTypeConfiguration<APIEndPoint>
    {
        public void Configure(EntityTypeBuilder<APIEndPoint> builder)
        {
            builder.HasIndex(p => p.CodApiEndPoint).IsUnique();
            builder.Property(p => p.CodApiEndPoint)
            .HasMaxLength(150);
            builder.Property(p => p.ApiURL)
            .HasMaxLength(250);
            builder.Property(p => p.ContentType)
            .HasMaxLength(100);
            builder.Property(p => p.Method)
            .HasMaxLength(10);
            builder.Property(p => p.Descripcion)
            .HasMaxLength(250);

            var fecha = Convert.ToDateTime(DateTime.Now);
            builder.HasData(new List<APIEndPoint>
            {
            new() {Id=1,CodApiEndPoint="SUNAT_SIRE_RCE_PROPUESTA",ApiURL="https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rce/propuesta/web/propuesta/{perTributario}/exportacioncomprobantepropuesta?perTributario={perTributario}&codTipoArchivo={codTipoArchivo}&codOrigenEnvio={codOrigenEnvio}",ContentType="application/json; charset=UTF-8",BodyRequest="",Method="GET",Descripcion="5.34 Servicio Web Api descargar propuesta", FechaCreacion=fecha},
            new() {Id=2,CodApiEndPoint="SUNAT_SIRE_RVIE_PROPUESTA",ApiURL="https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvie/propuesta/web/propuesta/{perTributario}/exportapropuesta?perTributario={perTributario}&codTipoArchivo={codTipoArchivo}",ContentType="application/json; charset=UTF-8",BodyRequest="",Method="GET",Descripcion="5.18 Servicio Web Api descargar propuesta   codTipoArchivo:   0=txt  1=csv", FechaCreacion=fecha},
            new() {Id=3,CodApiEndPoint="SUNAT_SIRE_RVIE_RCE_CONSULTAR_TICKET",ApiURL="https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/gestionprocesosmasivos/web/masivo/consultaestadotickets?perIni={perIni}&perFin={perFin}&page={page}&perPage={perPage}&numTicket={numTicket}",ContentType="application/json; charset=UTF-8",BodyRequest="",Method="GET",Descripcion="RVIE:5.16 Servicio Web Api consultar estado de envío de ticket RCE:5.34 Servicio Web Api descargar propuesta", FechaCreacion = fecha},
            new() {Id=4,CodApiEndPoint="SUNAT_SIRE_RVIE_RCE_DESCARGAR_ARCHIVO",ApiURL="https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/gestionprocesosmasivos/web/masivo/archivoreporte?nomArchivoReporte={nomArchivoReporte}&codTipoArchivoReporte=NULL&codLibro=140000",ContentType="application/json; charset=UTF-8",BodyRequest="",Method="GET",Descripcion="RVIE:5.17 Servicio Web Api descargar archivo RCE:5.32 Servicio Web Api descargar archivo", FechaCreacion = fecha},
            new() {Id=5,CodApiEndPoint="SUNAT_SIRE_SEGURIDAD",ApiURL="https://api-seguridad.sunat.gob.pe/v1/clientessol/{client_id}/oauth2/token/",ContentType="application/x-www-form-urlencoded; charset=UTF-8",BodyRequest="grant_type=password&scope={scope}&client_id={client_id}&client_secret={client_secret}&username={username}&password={password}",Method="POST",Descripcion="3. Generación de token para el uso de servicios REST", FechaCreacion=fecha},
            new() {Id=6,CodApiEndPoint="SUNAT_FE_GRE_ENVIO",ApiURL="https://api-cpe.sunat.gob.pe/v1/contribuyente/gem/comprobantes/",ContentType="application/json; charset=UTF-8",BodyRequest="",Method="POST",Descripcion="Envio de Guia Electronica de Remitente", FechaCreacion=fecha},
            new() {Id=7,CodApiEndPoint="SUNAT_FE_GRE_CONSULTA_TICKET",ApiURL="https://api-cpe.sunat.gob.pe/v1/contribuyente/gem/comprobantes/envios/",ContentType="application/json; charset=UTF-8",BodyRequest="",Method="GET",Descripcion="Consulta de Ticket GRE", FechaCreacion=fecha}
            });
        }
    }
}
