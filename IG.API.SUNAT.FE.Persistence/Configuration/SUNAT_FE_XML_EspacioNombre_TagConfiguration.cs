using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.API.SUNAT.FE.Persistence.Configuration
{
    public class SUNAT_FE_XML_EspacioNombre_TagConfiguration : IEntityTypeConfiguration<SUNATFEXMLEspacioNombreTag>
    {
        public void Configure(EntityTypeBuilder<SUNATFEXMLEspacioNombreTag> builder)
        {
            builder.Property(p => p.Codigo).HasMaxLength(150);
            builder.Property(p => p.Nombre).HasMaxLength(250);
            builder.Property(p => p.SUNAT).HasMaxLength(250);
            builder.Property(p => p.Efact).HasMaxLength(250);
            builder.Property(p => p.NubeFact).HasMaxLength(250);
            builder.HasIndex(p => p.Codigo).IsUnique();



            var fecha = Convert.ToDateTime(DateTime.Now);
            builder.HasData(new List<SUNATFEXMLEspacioNombreTag>
            {
                new () {Id= 1,Codigo = "nodoDescription",Nombre = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description", SUNAT = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description", NubeFact = "NULL", Efact = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description", FechaCreacion = fecha},
new () {Id= 2,Codigo = "nodoResponseCode",Nombre = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode", SUNAT = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode", NubeFact = "NULL", Efact = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode", FechaCreacion = fecha},
new () {Id= 3,Codigo = "nodoId ",Nombre = "/ar:ApplicationResponse/cbc:ID", SUNAT = "/ar:ApplicationResponse/cbc:ID", NubeFact = "NULL", Efact = "/ar:ApplicationResponse/cbc:ID", FechaCreacion = fecha},
new () {Id= 4,Codigo = "nodoNote",Nombre = "/ar:ApplicationResponse/cbc:Note", SUNAT = "/ar:ApplicationResponse/cbc:Note", NubeFact = "NULL", Efact = "/ar:ApplicationResponse/cbc:Note", FechaCreacion = fecha},
new () {Id= 5,Codigo = "nodoResponseDate ",Nombre = "/ar:ApplicationResponse/cbc:ResponseDate", SUNAT = "/ar:ApplicationResponse/cbc:ResponseDate", NubeFact = "NULL", Efact = "/ar:ApplicationResponse/cbc:ResponseDate", FechaCreacion = fecha},
new () {Id= 6,Codigo = "EnvResBase64",Nombre = "/soap-env:Envelope/soap-env:Body/br:sendBillResponse/applicationResponse", SUNAT = "/soap-env:Envelope/soap-env:Body/br:sendBillResponse/applicationResponse", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/br:sendBillResponse/applicationResponse", FechaCreacion = fecha},
new () {Id= 7,Codigo = "EnvResSummaryTicket",Nombre = "/soap-env:Envelope/soap-env:Body/br:sendSummaryResponse/ticket", SUNAT = "/soap-env:Envelope/soap-env:Body/br:sendSummaryResponse/ticket", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/br:sendSummaryResponse/ticket", FechaCreacion = fecha},
new () {Id= 8,Codigo = "envResCode",Nombre = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultcode", SUNAT = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultcode", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring", FechaCreacion = fecha},
new () {Id= 9,Codigo = "EnvResString",Nombre = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring", SUNAT = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring", NubeFact = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail", Efact = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring", FechaCreacion = fecha},
new () {Id= 10,Codigo = "nodoResponseTime ",Nombre = "ar:ApplicationResponse/cbc:ResponseTime", SUNAT = "ar:ApplicationResponse/cbc:ResponseTime", NubeFact = "NULL", Efact = "ar:ApplicationResponse/cbc:ResponseTime", FechaCreacion = fecha},
new () {Id= 11,Codigo = "wsse",Nombre = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xs", SUNAT = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xs", NubeFact = "NULL", Efact = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xs", FechaCreacion = fecha},
new () {Id= 12,Codigo = "wssecurity",Nombre = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", SUNAT = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", NubeFact = "NULL", Efact = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", FechaCreacion = fecha},
new () {Id= 13,Codigo = "soap-env",Nombre = "http://schemas.xmlsoap.org/soap/envelope/", SUNAT = "http://schemas.xmlsoap.org/soap/envelope/", NubeFact = "NULL", Efact = "http://schemas.xmlsoap.org/soap/envelope/", FechaCreacion = fecha},
new () {Id= 14,Codigo = "br",Nombre = "http://service.sunat.gob.pe", SUNAT = "http://service.sunat.gob.pe", NubeFact = "NULL", Efact = "http://service.sunat.gob.pe", FechaCreacion = fecha},
new () {Id= 15,Codigo = "ds ",Nombre = "http://www.w3.org/2000/09/xmldsig#", SUNAT = "http://www.w3.org/2000/09/xmldsig#", NubeFact = "NULL", Efact = "http://www.w3.org/2000/09/xmldsig#", FechaCreacion = fecha},
new () {Id= 16,Codigo = "xsi ",Nombre = "http://www.w3.org/2001/XMLSchema-instance", SUNAT = "http://www.w3.org/2001/XMLSchema-instance", NubeFact = "NULL", Efact = "http://www.w3.org/2001/XMLSchema-instance", FechaCreacion = fecha},
new () {Id= 17,Codigo = "ar ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2", FechaCreacion = fecha},
new () {Id= 18,Codigo = "cac ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", FechaCreacion = fecha},
new () {Id= 19,Codigo = "cbc ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", FechaCreacion = fecha},
new () {Id= 20,Codigo = "ext ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", FechaCreacion = fecha},
new () {Id= 21,Codigo = "xmlnsCreditNote ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", FechaCreacion = fecha},
new () {Id= 22,Codigo = "xmlnsDebitNote ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2", FechaCreacion = fecha},
new () {Id= 23,Codigo = "xmlnsDespatchAdvice ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", FechaCreacion = fecha},
new () {Id= 24,Codigo = "xmlnsInvoice",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", FechaCreacion = fecha},
new () {Id= 25,Codigo = "qdt ",Nombre = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2", SUNAT = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2", NubeFact = "NULL", Efact = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2", FechaCreacion = fecha},
new () {Id= 26,Codigo = "xmlnsPerception ",Nombre = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1", SUNAT = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1", NubeFact = "NULL", Efact = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1", FechaCreacion = fecha},
new () {Id= 27,Codigo = "xmlnsRetention ",Nombre = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1", SUNAT = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1", NubeFact = "NULL", Efact = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1", FechaCreacion = fecha},
new () {Id= 28,Codigo = "xmlnsSummaryDocuments ",Nombre = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1", SUNAT = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1", NubeFact = "NULL", Efact = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1", FechaCreacion = fecha},
new () {Id= 29,Codigo = "sac ",Nombre = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", SUNAT = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", NubeFact = "NULL", Efact = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", FechaCreacion = fecha},
new () {Id= 30,Codigo = "xmlnsVoidedDocuments ",Nombre = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1", SUNAT = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1", NubeFact = "NULL", Efact = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1", FechaCreacion = fecha},
new () {Id= 31,Codigo = "udt ",Nombre = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2", SUNAT = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2", NubeFact = "NULL", Efact = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2", FechaCreacion = fecha},
new () {Id= 32,Codigo = "ccts ",Nombre = "urn:un:unece:uncefact:documentation:2", SUNAT = "urn:un:unece:uncefact:documentation:2", NubeFact = "NULL", Efact = "urn:un:unece:uncefact:documentation:2", FechaCreacion = fecha},
new () {Id= 33,Codigo = "getStatusBase64",Nombre = "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/content", SUNAT = "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/content", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/content", FechaCreacion = fecha},
new () {Id= 34,Codigo = "getStatusCode",Nombre = "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/statusCode", SUNAT = "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/statusCode", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/statusCode/statusCode", FechaCreacion = fecha},
new () {Id= 35,Codigo = "nodoReferenceID",Nombre = "NULL", SUNAT = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ReferenceID", NubeFact = "NULL", Efact = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ReferenceID", FechaCreacion = fecha},
new () {Id= 36,Codigo = "getStatusCdrBase64",Nombre = "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/document", SUNAT = "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/content", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/document", FechaCreacion = fecha},
new () {Id= 37,Codigo = "EnvResDetail",Nombre = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail/detail", SUNAT = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail/detail", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail/detail", FechaCreacion = fecha},
new () {Id= 38,Codigo = "nodoDocDscrURL",Nombre = "NULL", SUNAT = "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:DocumentDescription", NubeFact = "NULL", Efact = "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:DocumentDescription", FechaCreacion = fecha},
new () {Id= 39,Codigo = "getstatusCdrCode",Nombre = "NULL", SUNAT = "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusCode", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusCode", FechaCreacion = fecha},
new () {Id= 40,Codigo = "getstatusCdrMessage",Nombre = "NULL", SUNAT = "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusMessage", NubeFact = "NULL", Efact = "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusMessage", FechaCreacion = fecha},
            });

        }
    }
}
