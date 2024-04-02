using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services
{
    public interface IFEServices
    {

        Task<BaseResponseGeneric<ApiGreSendDto>> SendApi(ComprobanteRequest request, maeEmpresa empresa);
        Task<BaseResponseGeneric<ApiGreConsultaDto>> ConsultarTicket(GetStatusRequestDto request, maeEmpresa empresa);
        Task<BaseResponseGeneric<ComprobanteResponseDto>> InsertComprobante(string Id, string XmlBase64, string NomArchivo,int IdmaeEmpresa , Respuesta response, string ticket);
        Task<BaseResponseGeneric<maeEmpresa>> GetEmpresaAsync(bool bProduccion,string DocumentoIdentidad);
    }
}
