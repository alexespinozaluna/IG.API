using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IG.API.SUNAT.FE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Version10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_EmpresaIdmaeEmpresa",
                table: "OauthAccessToken");

            migrationBuilder.DropIndex(
                name: "IX_OauthAccessToken_EmpresaIdmaeEmpresa",
                table: "OauthAccessToken");

            migrationBuilder.DropColumn(
                name: "EmpresaIdmaeEmpresa",
                table: "OauthAccessToken");

            migrationBuilder.RenameColumn(
                name: "IdmaeEmpresa",
                table: "OauthAccessToken",
                newName: "IdEmpresa");

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 59, 1, 609, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.CreateIndex(
                name: "IX_OauthAccessToken_IdEmpresa",
                table: "OauthAccessToken",
                column: "IdEmpresa",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_IdEmpresa",
                table: "OauthAccessToken",
                column: "IdEmpresa",
                principalTable: "maeEmpresa",
                principalColumn: "IdmaeEmpresa",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_IdEmpresa",
                table: "OauthAccessToken");

            migrationBuilder.DropIndex(
                name: "IX_OauthAccessToken_IdEmpresa",
                table: "OauthAccessToken");

            migrationBuilder.RenameColumn(
                name: "IdEmpresa",
                table: "OauthAccessToken",
                newName: "IdmaeEmpresa");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaIdmaeEmpresa",
                table: "OauthAccessToken",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 280, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 280, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 280, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 280, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 280, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 280, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 280, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 25, 12, 32, 46, 331, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.CreateIndex(
                name: "IX_OauthAccessToken_EmpresaIdmaeEmpresa",
                table: "OauthAccessToken",
                column: "EmpresaIdmaeEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_EmpresaIdmaeEmpresa",
                table: "OauthAccessToken",
                column: "EmpresaIdmaeEmpresa",
                principalTable: "maeEmpresa",
                principalColumn: "IdmaeEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
