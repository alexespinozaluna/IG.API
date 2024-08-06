using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services
{
    public interface ISistemaUsuarioService
    {
        Task<BaseResponseGeneric<SistemaUsuario>> GetUsuario(string CodUsuario);

        Task<BaseResponseGeneric<ICollection<SistemaUsuario>>> ListAsync();
        Task<BaseResponseGeneric<SistemaUsuario>> FindByIdAsync(int id);
        //Task<BaseResponseGeneric<maeEmpresa>> RucUsuarioAsync(string ruc, string usuario);
        Task<BaseResponseGeneric<int>> AddAsync(SistemaUsuario request);
        Task<BaseResponse> UpdateAsync(int Id, SistemaUsuario request);
        Task<BaseResponse> DeleteAsync(int Id);
    }
}
