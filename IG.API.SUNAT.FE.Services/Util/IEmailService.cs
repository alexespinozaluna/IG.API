using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;

namespace IG.API.SUNAT.FE.Services.Util
{
    public interface IEmailService
    {
        Task<string> SendMail(
            EmailConfig emailConfig, 
            EmailContentDto emailContentDto, 
            List<EmailAttachmentDto> emailAttachments, 
            List<EmailEmbeddedContentDto> emailEmbeddedContents);
    }
}
