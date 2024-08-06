using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IG.API.SUNAT.FE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Empresa_SistemaUsuario_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_IdmaeEmpresa",
                table: "OauthAccessToken");

            migrationBuilder.DropIndex(
                name: "IX_maeEmpresa_nvNumDocumentoIdentidad_bProduccion",
                table: "maeEmpresa");

            migrationBuilder.AlterColumn<string>(
                name: "nvNumDocumentoIdentidad",
                table: "maeEmpresa",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvEncoding",
                table: "maeEmpresa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvCertificadoPass",
                table: "maeEmpresa",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "ntCertificadoPfx",
                table: "maeEmpresa",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2147483647);

            migrationBuilder.AlterColumn<bool>(
                name: "bProduccion",
                table: "maeEmpresa",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SistemaUsuario",
                columns: table => new
                {
                    IdSistemaUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodSistemaUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomSistemaUsuario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PassUsuario = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EsAdministrador = table.Column<bool>(type: "bit", nullable: false),
                    Desactivado = table.Column<bool>(type: "bit", nullable: false),
                    CambiarPass = table.Column<bool>(type: "bit", nullable: false),
                    IdmaeEmpresa = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaUsuario", x => x.IdSistemaUsuario);
                    table.ForeignKey(
                        name: "FK_SistemaUsuario_maeEmpresa_IdmaeEmpresa",
                        column: x => x.IdmaeEmpresa,
                        principalTable: "maeEmpresa",
                        principalColumn: "IdmaeEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 595, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 595, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 595, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 595, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 595, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 595, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 595, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 6, 11, 19, 41, 13, 624, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.CreateIndex(
                name: "IX_maeEmpresa_nvNumDocumentoIdentidad_bProduccion",
                table: "maeEmpresa",
                columns: new[] { "nvNumDocumentoIdentidad", "bProduccion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SistemaUsuario_IdmaeEmpresa",
                table: "SistemaUsuario",
                column: "IdmaeEmpresa",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_IdmaeEmpresa",
                table: "OauthAccessToken",
                column: "IdmaeEmpresa",
                principalTable: "maeEmpresa",
                principalColumn: "IdmaeEmpresa",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_IdmaeEmpresa",
                table: "OauthAccessToken");

            migrationBuilder.DropTable(
                name: "SistemaUsuario");

            migrationBuilder.DropIndex(
                name: "IX_maeEmpresa_nvNumDocumentoIdentidad_bProduccion",
                table: "maeEmpresa");

            migrationBuilder.AlterColumn<string>(
                name: "nvNumDocumentoIdentidad",
                table: "maeEmpresa",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "nvEncoding",
                table: "maeEmpresa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "nvCertificadoPass",
                table: "maeEmpresa",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ntCertificadoPfx",
                table: "maeEmpresa",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "bProduccion",
                table: "maeEmpresa",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 443, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 443, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 443, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 443, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 443, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 443, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "APIEndPoint",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 443, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 12,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 14,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 16,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 18,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 20,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 22,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 24,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 26,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 28,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 30,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 32,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 34,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 36,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 38,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SUNATFEXMLEspacioNombreTag",
                keyColumn: "Id",
                keyValue: 40,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 26, 14, 17, 1, 492, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.CreateIndex(
                name: "IX_maeEmpresa_nvNumDocumentoIdentidad_bProduccion",
                table: "maeEmpresa",
                columns: new[] { "nvNumDocumentoIdentidad", "bProduccion" },
                unique: true,
                filter: "[nvNumDocumentoIdentidad] IS NOT NULL AND [bProduccion] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_OauthAccessToken_maeEmpresa_IdmaeEmpresa",
                table: "OauthAccessToken",
                column: "IdmaeEmpresa",
                principalTable: "maeEmpresa",
                principalColumn: "IdmaeEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
