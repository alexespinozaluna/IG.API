using System.IO.Compression;
namespace IG.API.SUNAT.RUC.Common
{
    internal class DescargarArchivo
    {
        public async Task Descargar(string urlDescargar, string rutaGuardar, string nombreArchivo)
        {

            string _rutaGuardarCompleta = Path.Combine(rutaGuardar, nombreArchivo);

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Envía una solicitud HTTP GET a la URL y obtén la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(urlDescargar);

                    // Verifica si la solicitud fue exitosa
                    response.EnsureSuccessStatusCode();

                    // Lee el contenido del archivo como un arreglo de bytes
                    byte[] archivoBytes = await response.Content.ReadAsByteArrayAsync();

                    // Guarda el archivo en la ruta especificada
                    File.WriteAllBytes(_rutaGuardarCompleta, archivoBytes);

                    //Descomprimir Archivo(s)
                    Descomprimir(_rutaGuardarCompleta, rutaGuardar);

                    //Console.WriteLine("Archivo descargado exitosamente en la ruta especificada.");
                }
                catch (HttpRequestException ex)
                {
                    throw ex;
                }
            }
        }
        public void Descomprimir(string rutaArchivoZip, string rutaArchivo)
        {

            try
            {
                using (ZipArchive archivoZip = ZipFile.OpenRead(rutaArchivoZip))
                {
                    foreach (ZipArchiveEntry entrada in archivoZip.Entries)
                    {

                        // Crea la ruta completa para el archivo descomprimido
                        string rutaArchivoDescomprimido = Path.Combine(rutaArchivo, entrada.FullName);

                        // Crea el directorio si no existe
                        Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivoDescomprimido));

                        // Descomprime el archivo
                        entrada.ExtractToFile(rutaArchivoDescomprimido, true);

                        Console.WriteLine($"Archivo descomprimido: {rutaArchivoDescomprimido}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descomprimir el archivo: {ex.Message}");
            }
        }

    }
}
