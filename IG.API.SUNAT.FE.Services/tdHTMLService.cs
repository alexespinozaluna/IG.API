using AutoMapper;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Repository;
using Microsoft.Extensions.Logging;

namespace IG.API.SUNAT.FE.Services
{
    public class tdHTMLService : ItdHTMLService
    {

        private readonly ItdHTMLRepo _repo;
        private readonly ILogger<tdHTMLService> _logger;
        private readonly IMapper _mapper;

        public tdHTMLService(ItdHTMLRepo repo, ILogger<tdHTMLService> logger, IMapper mapper)
        {
            _repo = repo;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<int>> AddAsync(tdHTML request)
        {
            var response = new BaseResponseGeneric<int>();

            try
            {
                // Codigo
                response.Data = await _repo.AddAsync(request);

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

        public async Task<BaseResponse> DeleteAsync(int Id)
        {
            var response = new BaseResponse();

            try
            {
                // Codigo
                await _repo.DeleteAsync(Id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Error al eliminar :{ex.Message}";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }

        public async Task<BaseResponseGeneric<tdHTML>> FindByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<tdHTML>();

            try
            {
                // Codigo
                response.Data = await _repo.FindByIdAsync(id);

                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Mensaje de Error";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;

        }

        public async Task<BaseResponseGeneric<ICollection<tdHTML>>> ListAsync()
        {
            var response = new BaseResponseGeneric<ICollection<tdHTML>>();

            try
            {
                // Codigo
                response.Data = await _repo.ListAsync();

                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Mensaje de Error: {ex.Message}";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }


        public async Task<BaseResponse> UpdateAsync(int Id, tdHTML request)
        {
            var response = new BaseResponse();
            try
            {
                // Codigo
                var entity = await _repo.FindByIdAsync(Id);
                if (entity is null)
                {
                    response.ErrorMessage = "El registro no se encuentra";
                    return response;
                }
                _mapper.Map(request, entity);

                await _repo.UpdateAsync();
                response.Success = true;

            }
            catch (Exception ex)
            {
                var ErrorMessage = "Error al actualizar Genero";
                _logger.LogError(ex, "{ErrorMessage} {Message}", ErrorMessage, ex.Message);
            }

            return response;
        }
    }
}
