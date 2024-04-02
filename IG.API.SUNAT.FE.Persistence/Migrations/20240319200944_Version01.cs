using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IG.API.SUNAT.FE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Version01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APIEndPoint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodApiEndPoint = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ApiURL = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BodyRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIEndPoint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "maeEmpresa",
                columns: table => new
                {
                    IdmaeEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bProduccion = table.Column<bool>(type: "bit", nullable: false),
                    NommaeEmpresa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nvNumDocumentoIdentidad = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    nvCodTipoDocumentoIdentidad = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    nvEncoding = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ntCertificadoPfx = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    nvCertificadoPass = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nvURLFE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    nvUsuarioFE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nvClaveFE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nvProveedorFE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ntSoapFE = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    nvScopeApiFE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nvClientIdApiFE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    nvClientSecretApiFE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    nvURLTokenApiFE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    nvURLENvioApiFE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    nvURLConsultaApiFE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maeEmpresa", x => x.IdmaeEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "OauthAccessToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ruc = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    access_token = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    token_type = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    expires_in = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    date_expires_in = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OauthAccessToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SUNAT_FE_Comprobante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomArchivo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    xmlFirmado = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ticket = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdComprobante = table.Column<int>(type: "int", nullable: false),
                    bProcesado = table.Column<bool>(type: "bit", nullable: false),
                    dtFechaHoraProceso = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    XmlCdr = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    URLDocumento = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUNAT_FE_Comprobante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SUNATFEXMLEspacioNombreTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SUNAT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NubeFact = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Efact = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUNATFEXMLEspacioNombreTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApiResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApiUrlSend = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApiEndPointId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    JsonResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MenssageError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApiResponse_APIEndPoint_ApiEndPointId",
                        column: x => x.ApiEndPointId,
                        principalTable: "APIEndPoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApiResponse_maeEmpresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "maeEmpresa",
                        principalColumn: "IdmaeEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "APIEndPoint",
                columns: new[] { "Id", "ApiURL", "BodyRequest", "CodApiEndPoint", "ContentType", "Descripcion", "FechaCreacion", "FechaModificacion", "Method" },
                values: new object[,]
                {
                    { 1, "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rce/propuesta/web/propuesta/{perTributario}/exportacioncomprobantepropuesta?perTributario={perTributario}&codTipoArchivo={codTipoArchivo}&codOrigenEnvio={codOrigenEnvio}", "", "SUNAT_SIRE_RCE_PROPUESTA", "application/json; charset=UTF-8", "5.34 Servicio Web Api descargar propuesta", new DateTime(2024, 3, 19, 17, 9, 44, 825, DateTimeKind.Local).AddTicks(2958), null, "GET" },
                    { 2, "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvie/propuesta/web/propuesta/{perTributario}/exportapropuesta?perTributario={perTributario}&codTipoArchivo={codTipoArchivo}", "", "SUNAT_SIRE_RVIE_PROPUESTA", "application/json; charset=UTF-8", "5.18 Servicio Web Api descargar propuesta   codTipoArchivo:   0=txt  1=csv", new DateTime(2024, 3, 19, 17, 9, 44, 825, DateTimeKind.Local).AddTicks(2958), null, "GET" },
                    { 3, "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/gestionprocesosmasivos/web/masivo/consultaestadotickets?perIni={perIni}&perFin={perFin}&page={page}&perPage={perPage}&numTicket={numTicket}", "", "SUNAT_SIRE_RVIE_RCE_CONSULTAR_TICKET", "application/json; charset=UTF-8", "RVIE:5.16 Servicio Web Api consultar estado de envío de ticket RCE:5.34 Servicio Web Api descargar propuesta", new DateTime(2024, 3, 19, 17, 9, 44, 825, DateTimeKind.Local).AddTicks(2958), null, "GET" },
                    { 4, "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/gestionprocesosmasivos/web/masivo/archivoreporte?nomArchivoReporte={nomArchivoReporte}&codTipoArchivoReporte=NULL&codLibro=140000", "", "SUNAT_SIRE_RVIE_RCE_DESCARGAR_ARCHIVO", "application/json; charset=UTF-8", "RVIE:5.17 Servicio Web Api descargar archivo RCE:5.32 Servicio Web Api descargar archivo", new DateTime(2024, 3, 19, 17, 9, 44, 825, DateTimeKind.Local).AddTicks(2958), null, "GET" },
                    { 5, "https://api-seguridad.sunat.gob.pe/v1/clientessol/{client_id}/oauth2/token/", "grant_type=password&scope={scope}&client_id={client_id}&client_secret={client_secret}&username={username}&password={password}", "SUNAT_SIRE_SEGURIDAD", "application/x-www-form-urlencoded; charset=UTF-8", "3. Generación de token para el uso de servicios REST", new DateTime(2024, 3, 19, 17, 9, 44, 825, DateTimeKind.Local).AddTicks(2958), null, "POST" }
                });

            migrationBuilder.InsertData(
                table: "SUNATFEXMLEspacioNombreTag",
                columns: new[] { "Id", "Codigo", "Efact", "FechaCreacion", "FechaModificacion", "Nombre", "NubeFact", "SUNAT" },
                values: new object[,]
                {
                    { 1, "nodoDescription", "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description", "NULL", "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description" },
                    { 2, "nodoResponseCode", "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode", "NULL", "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode" },
                    { 3, "nodoId ", "/ar:ApplicationResponse/cbc:ID", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/ar:ApplicationResponse/cbc:ID", "NULL", "/ar:ApplicationResponse/cbc:ID" },
                    { 4, "nodoNote", "/ar:ApplicationResponse/cbc:Note", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/ar:ApplicationResponse/cbc:Note", "NULL", "/ar:ApplicationResponse/cbc:Note" },
                    { 5, "nodoResponseDate ", "/ar:ApplicationResponse/cbc:ResponseDate", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/ar:ApplicationResponse/cbc:ResponseDate", "NULL", "/ar:ApplicationResponse/cbc:ResponseDate" },
                    { 6, "EnvResBase64", "/soap-env:Envelope/soap-env:Body/br:sendBillResponse/applicationResponse", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/br:sendBillResponse/applicationResponse", "NULL", "/soap-env:Envelope/soap-env:Body/br:sendBillResponse/applicationResponse" },
                    { 7, "EnvResSummaryTicket", "/soap-env:Envelope/soap-env:Body/br:sendSummaryResponse/ticket", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/br:sendSummaryResponse/ticket", "NULL", "/soap-env:Envelope/soap-env:Body/br:sendSummaryResponse/ticket" },
                    { 8, "envResCode", "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultcode", "NULL", "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultcode" },
                    { 9, "EnvResString", "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring", "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail", "/soap-env:Envelope/soap-env:Body/soap-env:Fault/faultstring" },
                    { 10, "nodoResponseTime ", "ar:ApplicationResponse/cbc:ResponseTime", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "ar:ApplicationResponse/cbc:ResponseTime", "NULL", "ar:ApplicationResponse/cbc:ResponseTime" },
                    { 11, "wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xs", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xs", "NULL", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xs" },
                    { 12, "wssecurity", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", "NULL", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" },
                    { 13, "soap-env", "http://schemas.xmlsoap.org/soap/envelope/", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "http://schemas.xmlsoap.org/soap/envelope/", "NULL", "http://schemas.xmlsoap.org/soap/envelope/" },
                    { 14, "br", "http://service.sunat.gob.pe", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "http://service.sunat.gob.pe", "NULL", "http://service.sunat.gob.pe" },
                    { 15, "ds ", "http://www.w3.org/2000/09/xmldsig#", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "http://www.w3.org/2000/09/xmldsig#", "NULL", "http://www.w3.org/2000/09/xmldsig#" },
                    { 16, "xsi ", "http://www.w3.org/2001/XMLSchema-instance", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "http://www.w3.org/2001/XMLSchema-instance", "NULL", "http://www.w3.org/2001/XMLSchema-instance" },
                    { 17, "ar ", "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2" },
                    { 18, "cac ", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" },
                    { 19, "cbc ", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" },
                    { 20, "ext ", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" },
                    { 21, "xmlnsCreditNote ", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2" },
                    { 22, "xmlnsDebitNote ", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2" },
                    { 23, "xmlnsDespatchAdvice ", "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2" },
                    { 24, "xmlnsInvoice", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" },
                    { 25, "qdt ", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2", "NULL", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" },
                    { 26, "xmlnsPerception ", "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1", "NULL", "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1" },
                    { 27, "xmlnsRetention ", "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1", "NULL", "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1" },
                    { 28, "xmlnsSummaryDocuments ", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1", "NULL", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1" },
                    { 29, "sac ", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", "NULL", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1" },
                    { 30, "xmlnsVoidedDocuments ", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1", "NULL", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1" },
                    { 31, "udt ", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2", "NULL", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" },
                    { 32, "ccts ", "urn:un:unece:uncefact:documentation:2", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "urn:un:unece:uncefact:documentation:2", "NULL", "urn:un:unece:uncefact:documentation:2" },
                    { 33, "getStatusBase64", "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/content", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/content", "NULL", "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/content" },
                    { 34, "getStatusCode", "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/statusCode/statusCode", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/statusCode", "NULL", "/soap-env:Envelope/soap-env:Body/br:getStatusResponse/status/statusCode" },
                    { 35, "nodoReferenceID", "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ReferenceID", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "NULL", "NULL", "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ReferenceID" },
                    { 36, "getStatusCdrBase64", "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/document", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/document", "NULL", "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/content" },
                    { 37, "EnvResDetail", "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail/detail", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail/detail", "NULL", "/soap-env:Envelope/soap-env:Body/soap-env:Fault/detail/detail" },
                    { 38, "nodoDocDscrURL", "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:DocumentDescription", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "NULL", "NULL", "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:DocumentDescription" },
                    { 39, "getstatusCdrCode", "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusCode", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "NULL", "NULL", "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusCode" },
                    { 40, "getstatusCdrMessage", "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusMessage", new DateTime(2024, 3, 19, 17, 9, 44, 836, DateTimeKind.Local).AddTicks(2892), null, "NULL", "NULL", "/soap-env:Envelope/soap-env:Body/br:getStatusCdrResponse/statusCdr/statusMessage" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_APIEndPoint_CodApiEndPoint",
                table: "APIEndPoint",
                column: "CodApiEndPoint",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApiResponse_ApiEndPointId",
                table: "ApiResponse",
                column: "ApiEndPointId");

            migrationBuilder.CreateIndex(
                name: "IX_ApiResponse_EmpresaId",
                table: "ApiResponse",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_maeEmpresa_nvNumDocumentoIdentidad_bProduccion",
                table: "maeEmpresa",
                columns: new[] { "nvNumDocumentoIdentidad", "bProduccion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SUNATFEXMLEspacioNombreTag_Codigo",
                table: "SUNATFEXMLEspacioNombreTag",
                column: "Codigo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiResponse");

            migrationBuilder.DropTable(
                name: "OauthAccessToken");

            migrationBuilder.DropTable(
                name: "SUNAT_FE_Comprobante");

            migrationBuilder.DropTable(
                name: "SUNATFEXMLEspacioNombreTag");

            migrationBuilder.DropTable(
                name: "APIEndPoint");

            migrationBuilder.DropTable(
                name: "maeEmpresa");
        }
    }
}
