using API.API.SUNAT.Xml;
using API.API.SUNAT.Xml.FE;
using AutoMapper;
using IG.API.SUNAT.FE.Dto;
using IG.API.SUNAT.FE.Entity;
using IG.API.SUNAT.FE.Repository;
using IG.API.SUNAT.FE.Repository.Util;
using IG.API.SUNAT.FE.Services.Util;
using Newtonsoft.Json;

namespace IG.API.SUNAT.FE.Services
{
    public class FEServices : IFEServices
    {
        private readonly IApiEndPointRepo _repoApiEndPoint;
        private readonly IOauthAccessTokenRepo _repoOauth;
        private readonly IMaeEmpresaRepo _repoEmpresa;
        private readonly IApiUtil _apiUtil;
        private readonly IFnDb _fnDb;
        private readonly ISUNAT_FE_ComprobanteRepo _sUNAT_FE_ComprobanteRepo;

        private readonly IMapper _mapper;

        public FEServices(
            IApiEndPointRepo repoApiEndPoint,
            IOauthAccessTokenRepo repoOauth,
            IMaeEmpresaRepo repoEmpresa,
            IApiUtil apiUtil,
            IFnDb fnDb,
            ISUNAT_FE_ComprobanteRepo sUNAT_FE_ComprobanteRepo,
            IMapper mapper
            )
        {
            _repoApiEndPoint = repoApiEndPoint;
            _repoOauth = repoOauth;
            _repoEmpresa = repoEmpresa;
            _apiUtil = apiUtil;
            _fnDb = fnDb;
            _sUNAT_FE_ComprobanteRepo = sUNAT_FE_ComprobanteRepo;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<ApiGreConsultaDto>> ConsultarTicket(GetStatusRequestDto request, maeEmpresa empresa)
        {
            var response = new BaseResponseGeneric<ApiGreConsultaDto>();
            try
            {
                // Codigo
                await GetToken(empresa);
                var infoEndPoint = await _repoApiEndPoint.GetApiEndPointInfoAsync(empresa.IdmaeEmpresa, "SUNAT_FE_GRE_CONSULTA_TICKET");
                infoEndPoint.ApiURL += request.Ticket;
                var parameters = new Dictionary<string, string> { };
                var responseData = await _apiUtil.MakeRequestAsync(infoEndPoint, parameters);

                if (responseData != null)
                {
                    response.Data = JsonConvert.DeserializeObject<ApiGreConsultaDto>(responseData.JsonResponse);
                    if (responseData is null)
                    {
                        response.ErrorMessage = responseData.MenssageError;
                    }
                }
                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Mensaje de Error al Consultar GRE {ex.Message}";
            }

            return response;
        }

        public async Task<BaseResponseGeneric<maeEmpresa>> GetEmpresaAsync(bool bProduccion, string DocumentoIdentidad)
        {
            var response = new BaseResponseGeneric<maeEmpresa>();

            try
            {
                // Codigo
                response.Data = await _repoEmpresa.GetEmpresaByRucProdAsync(bProduccion, DocumentoIdentidad);
                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Error al leer el Empresa: {ex.Message}";
            }

            return response;
        }
        public async Task GetToken(maeEmpresa empresa)
        {

            var username = empresa.nvUsuarioFE;
            var tokenDb = await _repoOauth.GetTokenDb(empresa.IdmaeEmpresa);
            //_token = tokenDb.access_token;
            //Si existe Token Generar Token y Guardar
            if (tokenDb.access_token is null)
            {
                var apiInfo = await _repoApiEndPoint.GetApiEndPointInfoAsync(empresa.IdmaeEmpresa, "SUNAT_SIRE_SEGURIDAD");
                var parameters = new Dictionary<string, string>
                    {
                        { "client_id", empresa.nvClientIdApiFE }
                    };
                var apiResponse = await _apiUtil.MakeRequestAsync(apiInfo, parameters);

                if (apiResponse != null)
                {
                    var enty = JsonConvert.DeserializeObject<OauthAccessToken>(apiResponse.JsonResponse);
                    if (enty.access_token != null)
                    {
                        enty.date_expires_in = (await _fnDb.GetDateTimeDb()).AddSeconds(enty.expires_in);
                        enty.username = username;
                        enty.IdmaeEmpresa = empresa.IdmaeEmpresa;
                        await _repoOauth.AddAsync(enty);
                        //_token = enty.access_token;
                    }
                }
            }

            //return _token;
        }
        public async Task<BaseResponseGeneric<ComprobanteResponseDto>> InsertComprobante(string Id, string XmlBase64, string NomArchivo, int IdmaeEmpresa, Respuesta request, string ticket)
        {
            var response = new BaseResponseGeneric<ComprobanteResponseDto>();

            try
            {
                string _Mensaje = request.faultstring;
                if (!string.IsNullOrEmpty(request.detail) & !string.IsNullOrEmpty(_Mensaje))
                    _Mensaje = request.faultstring + ":" + request.detail;
                // Codigo

                int IdReturn = 0;
                if (!string.IsNullOrEmpty(ticket))
                    IdReturn = await _sUNAT_FE_ComprobanteRepo.GetIdByIdComprobanteAndTicket(Id, ticket);

                if (IdReturn > 0)
                {

                    var enty = await _sUNAT_FE_ComprobanteRepo.FindByIdAsync(IdReturn);
                    enty.Codigo = request.faultcode;
                    enty.Mensaje = _Mensaje;
                    enty.Descripcion = request.Description;
                    enty.Observacion = request.Notes;
                    enty.XmlCdr = request.XMLCdr;
                    enty.URLDocumento = request.URLDocument;
                    enty.FechaModificacion = await _fnDb.GetDateTimeDb();

                    await _sUNAT_FE_ComprobanteRepo.UpdateAsync();

                }
                if (IdReturn > 0)
                {
                    await _sUNAT_FE_ComprobanteRepo.UpdateAsync();

                }
                else
                {
                    var enty = new SUNAT_FE_Comprobante
                    {
                        IdComprobante = Id,
                        nomArchivo = NomArchivo,
                        xmlFirmado = XmlBase64,
                        Codigo = request.faultcode,
                        Mensaje = _Mensaje,
                        Descripcion = request.Description,
                        Observacion = request.Notes,
                        XmlCdr = request.XMLCdr,
                        Ticket = request.ticket,
                        URLDocumento = request.URLDocument,
                        FechaCreacion = await _fnDb.GetDateTimeDb(),
                        IdmaeEmpresa = IdmaeEmpresa
                    };
                    IdReturn = await _sUNAT_FE_ComprobanteRepo.AddAsync(enty);
                }

                response.Data = _mapper.Map<ComprobanteResponseDto>(await _sUNAT_FE_ComprobanteRepo.FindByIdAsync(IdReturn));
                response.Success = true;

            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Error al agregar Comprobante: {ex.Message}";
            }

            return response;

        }

        public async Task<BaseResponseGeneric<ApiGreSendDto>> SendApi(ComprobanteRequest request, maeEmpresa empresa)
        {
            var response = new BaseResponseGeneric<ApiGreSendDto>();

            try
            {
                // Codigo
                await GetToken(empresa);

                var infoEndPoint = await _repoApiEndPoint.GetApiEndPointInfoAsync(empresa.IdmaeEmpresa, "SUNAT_FE_GRE_ENVIO");
                infoEndPoint.ApiURL += request.NomArchivo;
                infoEndPoint.RequestBody = request.XmlBase64;

                var parameters = new Dictionary<string, string> { };
                var responseData = await _apiUtil.MakeRequestAsync(infoEndPoint, parameters);

                if (responseData.JsonResponse != null)
                {

                    response.Data = JsonConvert.DeserializeObject<ApiGreSendDto>(responseData.JsonResponse);
                }
                else
                {
                    response.ErrorMessage = responseData.MenssageError;

                }
                response.Success = response.Data != null;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"Mensaje de Error al enviar GRE {ex.Message}";
            }
            return response;
        }

        public async Task<BaseResponseGeneric<FEComprobanteVenta>> LeerXmlAsync(LeerXMLDto request)
        {
            return await Task.Run(async () => {
                var response = new BaseResponseGeneric<FEComprobanteVenta>();

                try
                {
                    var xml = string.Empty;
                    if (request.TipoArchivo == "zip")
                    {
                      var  _descomprimir =  await _apiUtil.DescomprimirXmlAndToBase64Async(request.Base64);
                        xml = _descomprimir.Text;
                    }
                    else if(request.TipoArchivo == "zip")
                    {
                        xml = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(request.Base64));
                    }
                    else if (request.TipoArchivo == "txt")
                    {
                        xml = request.Base64;
                    }

                    BaseDocument document = XmlDeserializer.DeserializeXml(xml, request.TipoDocumento);
                    var _comprobante = new FEComprobanteVenta();

                    // Trabajar con el documento deserializado
                    if (document is Invoice invoice)
                        _comprobante = new FEComprobanteVenta(invoice);
                    else if (document is CreditNote creditNote)
                        _comprobante = new FEComprobanteVenta(creditNote);
                    else if (document is DebitNote debitNote)
                        _comprobante = new FEComprobanteVenta(debitNote);

                    if (string.IsNullOrEmpty(_comprobante.CodTipoDocumento))
                        _comprobante.CodTipoDocumento = request.TipoDocumento;

                    response.Data = _comprobante;
                    response.Success = response.Data != null;

                }
                catch (Exception ex)
                {
                    response.ErrorMessage = $"Mensaje de Error al Deserializar {ex.Message}";
                }
                return response;

            });
         
        }
    }
}
