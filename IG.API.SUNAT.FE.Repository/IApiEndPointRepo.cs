using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Repository
{
    public interface IApiEndPointRepo : IRepositoryBase<APIEndPoint>
    {
        Task<ApiEndPointInfo> GetApiEndPointInfoAsync(int IdIdmaeEmpresa, string CodApiEndPoint);
    }
}
