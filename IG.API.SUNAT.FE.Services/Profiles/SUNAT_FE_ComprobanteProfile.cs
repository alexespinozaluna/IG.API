using AutoMapper;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services.Profiles
{
    public class SUNAT_FE_ComprobanteProfile:Profile
    {
        public SUNAT_FE_ComprobanteProfile()
        {
            CreateMap<SUNAT_FE_Comprobante, ComprobanteResponseDto>();
        }
    }
}
