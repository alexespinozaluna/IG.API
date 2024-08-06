using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IG.API.SUNAT.FE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Empresa_imLogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "imLogo",
                table: "maeEmpresa",
                type: "image",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 551, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 551, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 551, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 551, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 551, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 551, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 551, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 24, 11, 51, 52, 596, DateTimeKind.Local).AddTicks(9423));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imLogo",
                table: "maeEmpresa");

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 223, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 223, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 223, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 223, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 223, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 223, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 223, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 7, 22, 17, 10, 9, 250, DateTimeKind.Local).AddTicks(9258));
        }
    }
}
