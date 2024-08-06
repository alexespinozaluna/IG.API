using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services
{
    public interface ItdHTMLService
    {
        Task<BaseResponseGeneric<ICollection<tdHTML>>> ListAsync();
        Task<BaseResponseGeneric<tdHTML>> FindByIdAsync(int id);
        Task<BaseResponseGeneric<int>> AddAsync(tdHTML request);
        Task<BaseResponse> UpdateAsync(int Id, tdHTML request);
        Task<BaseResponse> DeleteAsync(int Id);
    }
}
