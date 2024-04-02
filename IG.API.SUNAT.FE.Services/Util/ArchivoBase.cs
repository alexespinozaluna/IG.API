namespace IG.API.SUNAT.FE.Services.Util
{
        public class ArchivoBase
    {
        public string nomArchivo { get; set; }
        public string arcGreZip { get; set; }
        public string hashZip { get; set; }

    }

    public class Archivo
    {
        public ArchivoBase archivo { get; set; }
    }
}
