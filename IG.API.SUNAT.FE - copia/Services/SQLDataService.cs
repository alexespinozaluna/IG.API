using IG.API.SUNAT.FE.DataAccess;
using IG.API.SUNAT.FE.DTO;
using IG.API.SUNAT.FE.Entity;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace IG.API.SUNAT.FE.Services
{
    public class SQLDataService : ISQLDataService
    {
        private readonly IConexion _conexion;
        public SQLDataService(IConexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<BaseResponseGeneric<maeEmpresa>> GeTEmpresaAsync(string DocumentoIdentidad)
        {
            var response = new BaseResponseGeneric<maeEmpresa>();
            try
            {
                var sql = @"SELECT nvNumDocumentoIdentidad, nvCodTipoDocumentoIdentidad, nvEncoding, ntCertificadoPfx, nvCertificadoPass, nvURLFE, nvUsuarioFE, nvClaveFE, nvProveedorFE, ntSoapFE, nvScopeApiFE, nvClientIdApiFE, nvClientSecretApiFE, 
                  nvURLTokenApiFE, nvURLEnvioApiFE, nvURLConsultaApiFE
FROM     maeEmpresa" +
$" WHERE  (nvNumDocumentoIdentidad = '{DocumentoIdentidad}')";
                DataTable tb = await _conexion.getDataAsync(sql);

                if (tb.Rows.Count > 0)
                {
                    // Crear una instancia de Empresa y llenarla con los datos del DataTable
                    DataRow row = tb.Rows[0];
                    response.Data = new maeEmpresa
                    {
                        nvNumDocumentoIdentidad = row["nvNumDocumentoIdentidad"].ToString(),
                        nvCodTipoDocumentoIdentidad = row["nvCodTipoDocumentoIdentidad"].ToString(),
                        nvEncoding = row["nvEncoding"].ToString(),
                        ntCertificadoPfx = row["ntCertificadoPfx"].ToString(),
                        nvCertificadoPass = row["nvCertificadoPass"].ToString(),
                        nvURLFE = row["nvURLFE"].ToString(),
                        nvUsuarioFE = row["nvUsuarioFE"].ToString(),
                        nvClaveFE = row["nvClaveFE"].ToString(),
                        nvProveedorFE = row["nvProveedorFE"].ToString(),
                        ntSoapFE = row["ntSoapFE"].ToString(),
                        nvScopeApiFE = row["nvScopeApiFE"].ToString(),
                        nvClientIdApiFE = row["nvClientIdApiFE"].ToString(),
                        nvClientSecretApiFE = row["nvClientSecretApiFE"].ToString(),
                        nvURLTokenApiFE = row["nvURLTokenApiFE"].ToString(),
                        nvURLEnvioApiFE = row["nvURLEnvioApiFE"].ToString(),
                        nvURLConsultaApiFE = row["nvURLConsultaApiFE"].ToString()
                    };
                    response.Success= true; 
                }
            }
            catch (Exception ex)
            {

                response.ErrorMessage = $"Mensaje de Error {ex.Message}";
            }

            return response;
        }

        public async Task InsertComprobante(string Id, string XmlBase64, string NomArchivo, Respuesta response)
        {
            try
            {
                string sqlInsert = @"INSERT INTO SUNAT_FE_CLR_Comprobante 
(nomArchivo,xmlFirmado,Codigo,Mensaje,Descripcion,Observacion,Ticket,XmlCdr,URLDocumento,IdComprobante) VALUES
(@nomArchivo,@xmlFirmado,@Codigo,@Mensaje,@Descripcion,@Observacion,@Ticket,@XmlCdr,@URLDocumento,@IdComprobante) 
SELECT SCOPE_IDENTITY()";


                ArrayList parm = new ArrayList();
                parm.Add(new SqlParameter("@IdComprobante", Id));
                parm.Add(new SqlParameter("@nomArchivo", NomArchivo));
                parm.Add(new SqlParameter("@xmlFirmado", XmlBase64));
                parm.Add(new SqlParameter("@Codigo", response.faultcode));

                string _Mensaje = response.faultstring;
                if (!string.IsNullOrEmpty(response.detail) & !string.IsNullOrEmpty(_Mensaje))
                    _Mensaje = response.faultstring + ":" + response.detail;
                response.detail = _Mensaje;

                parm.Add(new SqlParameter("@Mensaje", _Mensaje));
                parm.Add(new SqlParameter("@Descripcion", response.Description));
                parm.Add(new SqlParameter("@Observacion", response.Notes));
                parm.Add(new SqlParameter("@XmlCdr", response.XMLCdr));
                parm.Add(new SqlParameter("@Ticket", response.ticket));
                parm.Add(new SqlParameter("@URLDocumento", response.URLDocument));


                await _conexion.InsertAsync(sqlInsert, parm);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
