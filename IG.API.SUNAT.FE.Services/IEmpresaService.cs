using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services
{
    public interface IEmpresaService
    {
        Task<BaseResponseGeneric<ICollection<maeEmpresa>>> ListAsync();
        Task<BaseResponseGeneric<maeEmpresa>> FindByIdAsync(int id);
        //Task<BaseResponseGeneric<maeEmpresa>> RucUsuarioAsync(string ruc, string usuario);
        Task<BaseResponseGeneric<int>> AddAsync(maeEmpresa request);
        Task<BaseResponse> UpdateAsync(int Id,maeEmpresa request);
        Task<BaseResponse> DeleteAsync(int Id);
    }
}
