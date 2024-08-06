using AutoMapper;
using Azure.Core;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Repository;
using Microsoft.Extensions.Logging;

namespace IG.API.SUNAT.FE.Services
{
    public class SUNAT_FE_ComprobanteService : ISUNAT_FE_ComprobanteService
    {
        private readonly ISUNAT_FE_ComprobanteRepo _repo;
        private readonly ILogger<SUNAT_FE_ComprobanteService> _logger;
        private readonly IMapper _mapper;

        public SUNAT_FE_ComprobanteService(ISUNAT_FE_ComprobanteRepo repo, ILogger<SUNAT_FE_ComprobanteService> logger, IMapper mapper)
        {
            _repo   = repo;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<BaseResponseGeneric<ICollection<SUNAT_FE_Comprobante>>> GetByDate(ComprobanteFilterDto request)
        {

            var response = new BaseResponseGeneric<ICollection<SUNAT_FE_Comprobante>>();

            try
            {
                // Codigo
                response.Data = await _repo.GetByDate(request);

                response.Success = response.Data != null;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Mensaje de Error: {ex.Message}";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }
    }
}
