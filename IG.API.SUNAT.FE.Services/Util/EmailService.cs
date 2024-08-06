using AutoMapper;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Repository;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace IG.API.SUNAT.FE.Services.Util
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfigRepo _repo;
        private readonly ILogger<EmailConfigService> _logger;
        private readonly IMapper _mapper;
        public EmailService(IEmailConfigRepo repo, ILogger<EmailConfigService> logger, IMapper mapper)
        {
            _repo = repo;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<string> SendMail(
            EmailConfig emailConfig,
            EmailContentDto emailContent,
            List<EmailAttachmentDto> emailAttachments,
            List<EmailEmbeddedContentDto> emailEmbeddedContents)
        {
            var result = string.Empty;
            try
            {

                if (emailConfig != null)
                {
                    string passwordBase64 = emailConfig.Password;
                    string password = Encoding.UTF8.GetString(Convert.FromBase64String(passwordBase64));
                    password = password.Substring(2, password.Length - 4);

                    var smtpClient = new SmtpClient
                    {
                        Host = emailConfig.Host,
                        Port = emailConfig.Port,
                        EnableSsl = emailConfig.EnableSsl,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(emailConfig.Email, password)
                    };


                    if (emailContent != null)
                    {
                        var _body = emailContent.Content;

                        var mailMessage = new MailMessage
                        {
                            IsBodyHtml = emailContent.IsHtml,
                            Body = _body,
                            BodyEncoding = Encoding.UTF8,
                            From = new MailAddress(emailConfig.Email, emailConfig.DisplayName),
                            Subject = emailContent.Subject,
                            SubjectEncoding = Encoding.UTF8,
                            Priority = MailPriority.Normal
                        };

                        foreach (var address in emailContent.EmailTo.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                            mailMessage.To.Add(address);

                        if (!string.IsNullOrEmpty(emailContent.EmailCC))
                        {
                            foreach (var address in emailContent.EmailCC.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                                mailMessage.CC.Add(address);
                        }

                        if (!string.IsNullOrEmpty(emailContent.EmailBcc))
                        {
                            foreach (var address in emailContent.EmailBcc.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                                mailMessage.Bcc.Add(address);
                        }

                        foreach (var attachment in emailAttachments)
                        {
                            var type = attachment.ContentType.ToLower();
                            var fileName = attachment.FileName;
                            Attachment fileData = null;

                            if (type == "bytes")
                            {
                                byte[] bytes = Convert.FromBase64String(attachment.Content);
                                fileData = new Attachment(new MemoryStream(bytes), fileName);
                            }
                            else if (type == "base64")
                            {
                                byte[] bytes = Convert.FromBase64String(attachment.Content);
                                fileData = new Attachment(new MemoryStream(bytes), fileName);
                            }
                            else if (type == "url")
                            {
                                byte[] bytes = new WebClient().DownloadData(attachment.Content);
                                fileData = new Attachment(new MemoryStream(bytes), fileName);
                            }
                            else if (type == "path")
                            {
                                fileData = new Attachment(attachment.Content);
                            }

                            mailMessage.Attachments.Add(fileData);
                        }

                        if (emailEmbeddedContents != null)
                        {
                            AlternateView alternateView = AlternateView.CreateAlternateViewFromString(_body, null, "text/html");

                            foreach (var embeddedContent in emailEmbeddedContents)
                            {
                                string contentId = embeddedContent.Cod;
                                string contentType = embeddedContent.ContentType.ToLower();
                                byte[] bytes = null;

                                if (contentType == "bytes")
                                {
                                    bytes = (byte[])embeddedContent.Content;
                                }
                                else if (contentType == "base64")
                                {
                                    bytes = Convert.FromBase64String((string)embeddedContent.Content);
                                }
                                else if (contentType == "url")
                                {
                                    bytes = new WebClient().DownloadData((string)embeddedContent.Content);
                                }
                                else
                                {
                                    bytes = File.ReadAllBytes(embeddedContent.Content.ToString());
                                }

                                LinkedResource linkedResource = new LinkedResource(new MemoryStream(bytes), embeddedContent.MediaType)
                                {
                                    ContentId = contentId
                                };

                                alternateView.LinkedResources.Add(linkedResource);
                            }
                            mailMessage.AlternateViews.Add(alternateView);
                        }

                        await smtpClient.SendMailAsync(mailMessage);

                        smtpClient.Dispose();
                        result = "OK";
                    }
                    else
                    {
                        result = "No hay datos a procesar!";
                    }
                }
                else
                {
                    result = "No se encuentra la Configuración!";
                }

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
    }
}
