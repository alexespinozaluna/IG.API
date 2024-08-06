using IG.API.SUNAT.FE.Dto;
using System.Xml;

namespace IG.API.SUNAT.FE.Services.Util
{
    public interface IApiUtil
    {
        Task<Entity.ApiResponse> MakeRequestAsync(ApiEndPointInfo apiEndPointInfo, Dictionary<string, string> parameters);
        Task<FileResponse> ExtractAllFileFromZipAsync(string Base64Zip, string fileNameTxt);
        Task<List<FileResponse>> ExtractAllFilesFromZipAsync(string Base64Zip);

        Task<string> FirmarAsync(string certificado, string pwd, string stringxml, string encoding, int indiceNodo);
        Task<string> ZipAsync(string strXml, string nombreArchivo);
        Task<string> EnviarSoapAsync(string url, string strSoap);
        Task<string> ReplaceNameValueAsync(string inputString, Dictionary<string, string> replacements);
        //Task<XmlDocument> DescomprimirXmlAsync(string base64Reponse);
        Task<XmlRes> DescomprimirXmlAndToBase64Async(string base64Reponse);
        Task<BaseResponseGeneric<Respuesta>> ObtenerRespuestaAsync(string responseSoapEnvio, string[] espaciodenombre, bool esResumen, string proveedor, string getStatusCode, string getStatusMessage, string nodoBase64 = "EnvResBase64", string arcCdr = null);
        Task<string> HashZipAsync(string base64);
        Task<string> CifrarSha512(string clave);


    }
}
