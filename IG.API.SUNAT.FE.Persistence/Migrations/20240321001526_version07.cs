using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IG.API.SUNAT.FE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class version07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 656, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 656, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 656, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 656, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 656, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.InsertData(
                table: "APIEndPoint",
                columns: new[] { "Id", "ApiURL", "BodyRequest", "CodApiEndPoint", "ContentType", "Descripcion", "FechaCreacion", "FechaModificacion", "Method" },
                values: new object[,]
                {
                    { 6, "https://api-cpe.sunat.gob.pe/v1/contribuyente/gem/comprobantes/", "", "SUNAT_FE_GRE_ENVIO", "application/x-www-form-urlencoded; charset=UTF-8", "Envio de Guia Electronica de Remitente", new DateTime(2024, 3, 20, 21, 15, 26, 656, DateTimeKind.Local).AddTicks(1073), null, "POST" },
                    { 7, "https://api-cpe.sunat.gob.pe/v1/contribuyente/gem/comprobantes/envios/", "", "SUNAT_FE_GRE_CONSULTA_TICKET", "application/x-www-form-urlencoded; charset=UTF-8", "Consulta de Ticket GRE", new DateTime(2024, 3, 20, 21, 15, 26, 656, DateTimeKind.Local).AddTicks(1073), null, "GET" }
                });

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 21, 15, 26, 667, DateTimeKind.Local).AddTicks(5110));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 247, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 247, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 247, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 247, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 247, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 20, 11, 11, 7, 261, DateTimeKind.Local).AddTicks(3180));
        }
    }
}
