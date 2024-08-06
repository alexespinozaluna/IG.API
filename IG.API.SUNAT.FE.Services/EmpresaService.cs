using AutoMapper;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Repository;
using Microsoft.Extensions.Logging;

namespace IG.API.SUNAT.FE.Services
{

    public class EmpresaService : IEmpresaService
    {
        private readonly IMaeEmpresaRepo _repoEmpresa;
        private readonly ILogger<EmpresaService> _logger;
        private readonly IMapper _mapper;

        public EmpresaService(IMaeEmpresaRepo repoEmpresa, ILogger<EmpresaService> logger, IMapper mapper)
        {
            _repoEmpresa = repoEmpresa;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<int>> AddAsync(maeEmpresa request)
        {
            var response = new BaseResponseGeneric<int>();

            try
            {
                // Codigo
                response.Data = await _repoEmpresa.AddAsync(request);

                response.Success = response.Data != null;
                response.Success=true;
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
                await _repoEmpresa.DeleteAsync(Id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Error al eliminar :{ex.Message}";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }

        public async Task<BaseResponseGeneric<maeEmpresa>> FindByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<maeEmpresa>();

            try
            {
                // Codigo
                response.Data = await _repoEmpresa.FindByIdAsync(id);

                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = "Mensaje de Error";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;

        }

        public async Task<BaseResponseGeneric<ICollection<maeEmpresa>>> ListAsync()
        {
            var response = new BaseResponseGeneric<ICollection<maeEmpresa>>();

            try
            {
                // Codigo
                response.Data = await _repoEmpresa.ListAsync();

                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Mensaje de Error: {ex.Message}";
                _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }

        //public async Task<BaseResponseGeneric<maeEmpresa>> RucUsuarioAsync(string ruc, string usuario)
        //{
        //    var response = new BaseResponseGeneric<maeEmpresa>();

        //    try
        //    {
        //        // Codigo
        //        var _data = await _repoEmpresa.ListAsync(predicate: p => p.nvNumDocumentoIdentidad == ruc && p.nvUsuarioWeb == usuario);
        //        response.Data = _data[0];

        //        response.Success = response.Data != null;
        //    }
        //    catch (Exception ex)
        //    {
        //        response.ErrorMessage = "Mensaje de Error";
        //        _logger.LogError(ex, "{ErrorMessage} {Message}", response.ErrorMessage, ex.Message);
        //    }

        //    return response;
        //}

        public async Task<BaseResponse> UpdateAsync(int Id, maeEmpresa request)
        {
            var response = new BaseResponse();
            try
            {
                // Codigo
                var entity = await _repoEmpresa.FindByIdAsync(Id);
                if (entity is null)
                {
                    response.ErrorMessage = "El registro no se encuentra";
                    return response;
                }
                _mapper.Map(request, entity);

                await _repoEmpresa.UpdateAsync();
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
