using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services
{
    public interface IEmailConfigService
    {
        Task<BaseResponseGeneric<ICollection<EmailConfig>>> ListAsync();
        Task<BaseResponseGeneric<EmailConfig>> FindByIdAsync(int id);
        Task<BaseResponseGeneric<int>> AddAsync(EmailConfig request);
        Task<BaseResponse> UpdateAsync(int Id, EmailConfig request);
        Task<BaseResponse> DeleteAsync(int Id);
    }
}
