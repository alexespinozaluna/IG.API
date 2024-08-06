using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IG.API.SUNAT.FE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Empresa_IdmaeEmpresa_a_IdEmpresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SistemaUsuario_maeEmpresa_IdmaeEmpresa",
                table: "SistemaUsuario");

            migrationBuilder.RenameColumn(
                name: "IdmaeEmpresa",
                table: "SistemaUsuario",
                newName: "IdEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_SistemaUsuario_IdmaeEmpresa",
                table: "SistemaUsuario",
                newName: "IX_SistemaUsuario_IdEmpresa");

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 588, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 588, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 588, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 588, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 588, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 588, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 588, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 19, 19, 39, 27, 612, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.AddForeignKey(
                name: "FK_SistemaUsuario_maeEmpresa_IdEmpresa",
                table: "SistemaUsuario",
                column: "IdEmpresa",
                principalTable: "maeEmpresa",
                principalColumn: "IdmaeEmpresa",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SistemaUsuario_maeEmpresa_IdEmpresa",
                table: "SistemaUsuario");

            migrationBuilder.RenameColumn(
                name: "IdEmpresa",
                table: "SistemaUsuario",
                newName: "IdmaeEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_SistemaUsuario_IdEmpresa",
                table: "SistemaUsuario",
                newName: "IX_SistemaUsuario_IdmaeEmpresa");

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 874, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 874, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 874, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 874, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 874, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 874, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 874, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 14, 10, 4, 41, 897, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.AddForeignKey(
                name: "FK_SistemaUsuario_maeEmpresa_IdmaeEmpresa",
                table: "SistemaUsuario",
                column: "IdmaeEmpresa",
                principalTable: "maeEmpresa",
                principalColumn: "IdmaeEmpresa",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
