using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IG.API.SUNAT.FE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PROC_spGetApiEndPointInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
-- =============================================
-- Author:		Alex Espinoza Luna
-- Create date: 12/03/2024
-- Description:	Devuelve informaticon de web api a comsumir
-- =============================================
CREATE OR ALTER     PROCEDURE [spGetApiEndPointInfo]
(
@IdmaeEmpresa INT,
@CodApiEndPoint NVARCHAR(150)
)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @BodyRequest NVARCHAR(MAX)
	DECLARE @access_token NVARCHAR(MAX)

	IF(@CodApiEndPoint='SUNAT_SIRE_SEGURIDAD')
	BEGIN
		SELECT 
		@BodyRequest = BodyRequest
		FROM ApiEndPoint a 
		WHERE CodApiEndPoint= @CodApiEndPoint

		SET 
		@BodyRequest =(
					SELECT 
					REPLACE(
						REPLACE(
							REPLACE(
								REPLACE(
									REPLACE(@BodyRequest,'{scope}',a.nvScopeApiFE),
								'{client_id}',a.nvClientIdApiFE),
							'{client_secret}',a.nvClientSecretApiFE),
						'{username}',a.nvUsuarioFE),
					'{password}',a.nvClaveFE) 	
		FROM maeEmpresa a 
		WHERE IdmaeEmpresa = @IdmaeEmpresa
		)
	END
	ELSE
	SET @access_token = (
					SELECT a.access_token
					FROM OauthAccessToken a 
					INNER JOIN maeEmpresa b ON a.IdmaeEmpresa = b.IdmaeEmpresa
					WHERE b.IdmaeEmpresa = @IdmaeEmpresa
					)



	SELECT  
	a.Id,
	 @IdmaeEmpresa  AS IdmaeEmpresa,
	CodApiEndPoint,
	a.Method   , 
	a.ApiURL,  
	@BodyRequest AS RequestBody,  
	a.ContentType AS ContentType,  
	CASE 
		WHEN CodApiEndPoint = 'SUNAT_SIRE_SEGURIDAD' THEN NULL 
		ELSE 'Bearer '+@access_token END AS	[Authorization],
	CASE 
		WHEN CodApiEndPoint='SUNAT_SIRE_RVIE_RCE_DESCARGAR_ARCHIVO' THEN 'BYTE'
		ELSE NULL END AS ResponseType
	FROM ApiEndPoint a
	WHERE CodApiEndPoint = @CodApiEndPoint
END
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("DROP PROCEDURE  spGetApiEndPointInfo;");
        }
    }
}
