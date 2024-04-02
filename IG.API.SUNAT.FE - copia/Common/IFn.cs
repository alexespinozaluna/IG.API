using IG.API.SUNAT.FE.DTO;
using System.Xml;

namespace IG.API.SUNAT.FE.Common
{
    public interface IFn
    {
        Task<string> FirmarAsync(string certificado, string pwd, string stringxml, string encoding, int indiceNodo);
        Task<string> ZipAsync(string strXml, string nombreArchivo);
        Task<string> enviarSoapAsync(string url, string strSoap);
        Task<XmlDocument> DescomprimirXmlAsync(string base64Reponse);
        Task<XmlRes> DescomprimirXmlAndToBase64Async(string base64Reponse);
        Task<Respuesta> ObtenerRespuestaAsync(string responseSoapEnvio, string[] espaciodenombre, bool esResumen, string proveedor, string getStatusCode, string getStatusMessage, string nodoBase64 = "EnvResBase64", string arcCdr = null);
        Task<string> HashZipAsync(string base64);
        
    }
}
