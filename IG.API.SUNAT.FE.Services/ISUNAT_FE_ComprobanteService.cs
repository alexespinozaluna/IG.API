
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services
{

    public interface ISUNAT_FE_ComprobanteService
    {
        Task<BaseResponseGeneric<ICollection<SUNAT_FE_Comprobante>>> GetByDate(ComprobanteFilterDto request);
    }
}
