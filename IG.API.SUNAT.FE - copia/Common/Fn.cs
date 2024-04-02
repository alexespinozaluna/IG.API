using IG.API.SUNAT.FE.DTO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography;
using IG.API.SUNAT.FE.DataAccess;

namespace IG.API.SUNAT.FE.Common
{
    public class Fn : IFn
    {
        private readonly IConexion _conexion;
        public Fn(IConexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<string> FirmarAsync(string certificado, string pwd, string stringxml, string encoding, int indiceNodo)
        {
            var task = await Task.Factory.StartNew(() =>
            {
                string xmlFirmado = string.Empty;
                try
                {
                    #region FIRMADO            
                    var certificate = new X509Certificate2(Convert.FromBase64String(certificado),
                        pwd, X509KeyStorageFlags.MachineKeySet);

                    var xmlDoc = new XmlDocument();

                    xmlDoc.PreserveWhitespace = true;
                    byte[] _bytes = System.Text.Encoding.UTF8.GetBytes(stringxml);
                    string _strgXmlUTF8 = System.Text.Encoding.UTF8.GetString(_bytes);


                    XDocument docXD = XDocument.Parse(_strgXmlUTF8);


                    stringxml = docXD.ToString();

                    xmlDoc.LoadXml(stringxml);



                    var nodoExtension = xmlDoc.GetElementsByTagName("ExtensionContent", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
                        .Item(indiceNodo);
                    if (nodoExtension == null)
                        throw new InvalidOperationException("No se pudo encontrar el nodo ExtensionContent en el XML");
                    nodoExtension.RemoveAll();

                    // Creamos el objeto SignedXml.
                    var signedXml = new SignedXml(xmlDoc) { SigningKey = certificate.PrivateKey };
                    var xmlSignature = signedXml.Signature;

                    var env = new XmlDsigEnvelopedSignatureTransform();

                    var reference = new Reference(string.Empty);
                    reference.AddTransform(env);
                    xmlSignature.SignedInfo.AddReference(reference);

                    var keyInfo = new KeyInfo();
                    var x509Data = new KeyInfoX509Data(certificate);

                    x509Data.AddSubjectName(certificate.Subject);

                    keyInfo.AddClause(x509Data);
                    xmlSignature.KeyInfo = keyInfo;
                    xmlSignature.Id = "signatureKG";
                    signedXml.ComputeSignature();

                    nodoExtension.AppendChild(signedXml.GetXml());

                    using (var memDoc = new MemoryStream())
                    {
                        if (encoding.ToUpper().Equals("UTF-8"))
                        {
                            using (var writer = XmlWriter.Create(memDoc,
                       new XmlWriterSettings { Encoding = new UTF8Encoding(false) }))
                            {
                                xmlDoc.WriteTo(writer);
                            }
                        }
                        else
                        {

                            using (var writer = XmlWriter.Create(memDoc,
                                new XmlWriterSettings { Encoding = Encoding.GetEncoding(encoding) }))
                            {
                                xmlDoc.WriteTo(writer);
                            }
                        }

                        xmlFirmado = Convert.ToBase64String(memDoc.ToArray());
                    }
                    #endregion FIRMADO
                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Error al generar el XML:" + ex.Message);
                }

                return xmlFirmado;
            });

            return task;
        }

        public async Task<string> ZipAsync(string strXml, string nombreArchivo)
        {
            var task = await Task.Factory.StartNew(() =>
            {
                string resultado;

                using (var memDestino = new MemoryStream())
                {
                    using (var ziparchive = new ZipArchive(memDestino, ZipArchiveMode.Create))
                    {

                        var zipItem = ziparchive.CreateEntry($"{nombreArchivo}.xml");

                        using (var zipFile = zipItem.Open())
                        {
                            var data = Convert.FromBase64String(strXml);
                            zipFile.Write(data, 0, data.Length);
                        }
                    }

                    resultado = Convert.ToBase64String(memDestino.ToArray());
                }
                return resultado;

            });

            return task;
        }

        public async Task<string> enviarSoapAsync(string url, string strSoap)
        {
            string soapResponse = string.Empty;

            try
            {
                XmlDocument soapEnvelopeXml = new XmlDocument();
                soapEnvelopeXml.LoadXml(strSoap);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add(@"SOAP:Action");
                request.ContentType = "text/xml;charset=\"utf-8\"";
                request.Accept = "text/xml";
                request.Method = "POST";
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

                using (Stream stream = await request.GetRequestStreamAsync())
                {
                    soapEnvelopeXml.Save(stream);
                }

                using (System.Net.WebResponse response = await request.GetResponseAsync())
                {
                    using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                    {
                        soapResponse = await rd.ReadToEndAsync();
                    }
                }
            }
            catch (WebException webex)
            {
                WebResponse errResp = webex.Response;
                using (Stream respStream = errResp.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream);
                    soapResponse = await reader.ReadToEndAsync();
                }
            }

            return soapResponse;
        }

        public async Task<XmlDocument> DescomprimirXmlAsync(string base64Reponse)
        {
            var xml = new XmlDocument();

            using (var memRespuesta = new MemoryStream(Convert.FromBase64String(base64Reponse)))
            {
                using (System.IO.Compression.ZipArchive zipFile =
                    new System.IO.Compression.ZipArchive(memRespuesta, System.IO.Compression.ZipArchiveMode.Read))
                {
                    foreach (System.IO.Compression.ZipArchiveEntry entry in zipFile.Entries)
                    {
                        if (!entry.Name.EndsWith(".xml"))
                            continue;

                        using (Stream ms = entry.Open())
                        {
                            using (var reader = new StreamReader(ms))
                            {
                                var responseString = await reader.ReadToEndAsync();
                                xml.LoadXml(responseString);
                            }
                        }
                    }
                }
            }

            return xml;
        }

        public async Task<XmlRes> DescomprimirXmlAndToBase64Async(string base64Reponse)
        {
            var xmlRes = new XmlRes();

            using (var memRespuesta = new MemoryStream(Convert.FromBase64String(base64Reponse)))
            {
                using (System.IO.Compression.ZipArchive zipFile =
            new System.IO.Compression.ZipArchive(memRespuesta, System.IO.Compression.ZipArchiveMode.Read))
                {
                    foreach (System.IO.Compression.ZipArchiveEntry entry in zipFile.Entries)
                    {
                        if (!entry.Name.EndsWith(".xml"))
                            continue;

                        using (Stream ms = entry.Open())
                        {
                            using (var reader = new StreamReader(ms))
                            {
                                var responseString = await reader.ReadToEndAsync();
                                var xml = new XmlDocument();
                                var xmlBase64 = string.Empty;
                                xml.LoadXml(responseString);

                                using (var memDoc = new MemoryStream())
                                {
                                    using (var writer = XmlWriter.Create(memDoc))
                                    {
                                        xml.WriteTo(writer);
                                    }

                                    xmlBase64 = Convert.ToBase64String(memDoc.ToArray());
                                }

                                xmlRes.XmlDoc = xml;
                                xmlRes.XmlFileBase64 = xmlBase64;
                            }
                        }
                    }
                }
            }

            return xmlRes;
        }

       public async Task<Respuesta> ObtenerRespuestaAsync(string responseSoapEnvio, string[] espaciodenombre, bool esResumen, string proveedor, string getStatusCode, string getStatusMessage, string nodoBase64, string arcCdr)
        {
            
                var res = new Respuesta();
                var _cod = string.Empty;
                var _menssaje = string.Empty;

                try
                {
                    if (string.IsNullOrEmpty(arcCdr))
                    {
                        var xmlDocSoap = new XmlDocument();
                        var xmlnsManager = new XmlNamespaceManager(xmlDocSoap.NameTable);

                        if (string.IsNullOrEmpty(responseSoapEnvio))
                            throw new ApplicationException("La respuesta de CDR es Nulo. Consulte con su Administrador");

                        if (responseSoapEnvio.ToLower().Contains("<html"))
                        {
                            res.faultstring = responseSoapEnvio;
                            return res;
                        }

                        xmlDocSoap.LoadXml(responseSoapEnvio);

                        foreach (var item in espaciodenombre)
                            xmlnsManager.AddNamespace(item, await _conexion.getNamespaceDataAsync(item, proveedor));

                        res.faultcode = xmlDocSoap.SelectSingleNode(await _conexion.getNamespaceDataAsync("envResCode", proveedor), xmlnsManager)?.InnerText;
                        res.faultstring = xmlDocSoap.SelectSingleNode(await _conexion.getNamespaceDataAsync("EnvResString", proveedor), xmlnsManager)?.InnerText;
                        res.detail = xmlDocSoap.SelectSingleNode(await _conexion.getNamespaceDataAsync("EnvResDetail", proveedor), xmlnsManager)?.InnerText;

                        if (!string.IsNullOrEmpty(getStatusCode))
                            _cod = xmlDocSoap.SelectSingleNode(await _conexion.getNamespaceDataAsync(getStatusCode, proveedor), xmlnsManager)?.InnerText;
                        if (!string.IsNullOrEmpty(getStatusMessage))
                            _menssaje = xmlDocSoap.SelectSingleNode(await _conexion.getNamespaceDataAsync(getStatusMessage, proveedor), xmlnsManager)?.InnerText;

                        if (string.IsNullOrEmpty(res.faultcode))
                            res.faultcode = _cod;
                        if (string.IsNullOrEmpty(res.faultstring))
                            res.faultstring = _menssaje;

                        if (esResumen)
                        {
                            res.ticket = xmlDocSoap.SelectSingleNode(await _conexion.getNamespaceDataAsync("EnvResSummaryTicket", proveedor), xmlnsManager)?.InnerText;
                        }
                        else
                        {
                            res.applicationResponse = xmlDocSoap.SelectSingleNode(await _conexion.getNamespaceDataAsync(nodoBase64, proveedor), xmlnsManager)?.InnerText;
                        }
                    }

                    res.applicationResponse = arcCdr ?? res.applicationResponse;

                    if (!string.IsNullOrEmpty(res.applicationResponse))
                    {
                        if (res.applicationResponse.Length > 70)
                        {
                            var _descomprimir = await DescomprimirXmlAndToBase64Async(res.applicationResponse);

                            var xmlResponse = _descomprimir.XmlDoc;

                            var xmlsManagerSunat = new XmlNamespaceManager(xmlResponse.NameTable);
                            string[] espaciodenombreSoap = { "ar", "cac", "cbc" };
                            foreach (var item in espaciodenombreSoap)
                                xmlsManagerSunat.AddNamespace(item, await _conexion.getNamespaceDataAsync(item, proveedor));

                            var lstNotas = new List<string>();

                            foreach (XmlNode nota in xmlResponse.SelectNodes(await _conexion.getNamespaceDataAsync("nodoNote", proveedor), xmlsManagerSunat))
                            {
                                lstNotas.Add(nota.InnerText);
                            }
                            res.XMLCdr = _descomprimir.XmlFileBase64;
                            res.Notes = string.Join(",", lstNotas.ToArray());
                            res.faultcode = xmlResponse.SelectSingleNode(await _conexion.getNamespaceDataAsync("nodoResponseCode", proveedor), xmlsManagerSunat)?.InnerText;
                            res.Description = xmlResponse.SelectSingleNode(await _conexion.getNamespaceDataAsync("nodoDescription", proveedor), xmlsManagerSunat)?.InnerText;
                            res.URLDocument = xmlResponse.SelectSingleNode(await _conexion.getNamespaceDataAsync("nodoDocDscrURL", proveedor), xmlsManagerSunat)?.InnerText;

                            if (!string.IsNullOrEmpty(res.Description))
                                res.faultstring = null;

                        }
                        else
                        {
                            res.faultstring = res.applicationResponse;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return res;
            
        }

      public async   Task<string> HashZipAsync(string base64)
        {
 

            byte[] bytes = null;
            StringBuilder sb = new StringBuilder();
            var data = Convert.FromBase64String(base64);

            using (SHA256 sha256 = SHA256Managed.Create())
            {
                using (var stream = new MemoryStream(data))
                {
                    bytes = await sha256.ComputeHashAsync(stream);
                }
            }

            for (int i = 0; i <= bytes.Length - 1; i++)
                sb.AppendFormat("{0:x2}", bytes[i]);

            return sb.ToString();
        }
    }
}
