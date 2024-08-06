using AutoMapper;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IG.API.SUNAT.FE.Services
{
    public class SistemaUsuarioService : ISistemaUsuarioService
    {
        private readonly ILogger<SistemaUsuarioService> _logger;
        private readonly ISistemaUsuarioRepo _repo;
        private readonly IMapper _mapper;


        public SistemaUsuarioService(ILogger<SistemaUsuarioService> logger, ISistemaUsuarioRepo repo, IMapper mapper)
        {
            _logger = logger;
            _repo = repo;
            _mapper = mapper;
        }


        public async Task<BaseResponseGeneric<int>> AddAsync(SistemaUsuario request)
        {
            var response = new BaseResponseGeneric<int>();

            try
            {
                // Codigo
                response.Data = await _repo.AddAsync(request);

                response.Success = response.Data != null;
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

        public async Task<BaseResponseGeneric<SistemaUsuario>> FindByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<SistemaUsuario>();

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

        public async Task<BaseResponseGeneric<SistemaUsuario>> GetUsuario(string CodUsuario)
        {
            var response = new BaseResponseGeneric<SistemaUsuario>();

            try
            {
                // Codigo
                response.Data = await _repo.GetUsuario(CodUsuario);

                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Comuniquese con su Administrador";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;

        }

        public async Task<BaseResponseGeneric<ICollection<SistemaUsuario>>> ListAsync()
        {
            var response = new BaseResponseGeneric<ICollection<SistemaUsuario>>();

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

        public async Task<BaseResponse> UpdateAsync(int Id, SistemaUsuario request)
        {
            var response = new BaseResponse();
            try
            {
                // Codigo
                var entity = await _repo.FindByIdAsync(Id);
                if (entity is null)
                {
                    response.ErrorMessage = "El  registro no se encuentra";
                    return response;
                }
                _mapper.Map(request, entity);

                await _repo.UpdateAsync();
                response.Success = true;
            }
            catch (DbUpdateException dbEx)
            {
                var ErrorMessage = $"Error al actualizar Usuario: {dbEx.InnerException?.Message ?? dbEx.Message}";
                _logger.LogError(dbEx, "{ErrorMessage} {Message}", ErrorMessage, dbEx.Message);
                response.ErrorMessage = ErrorMessage;
            }
            catch (Exception ex)
            {
                var ErrorMessage = $"Error al actualizar Usuario: {ex.Message}";
                _logger.LogError(ex, "{ErrorMessage} {Message}", ErrorMessage, ex.Message);
            }

            return response;
        }
    }
}
