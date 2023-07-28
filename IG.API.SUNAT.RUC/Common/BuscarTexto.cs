using IG.API.SUNAT.RUC.Model;
using System.Text;
namespace IG.API.SUNAT.RUC.Common
{
    public class BuscarTexto
    {
        public async Task<Contribuyente> Buscar(string filePath, string searchText,char separador)
        {
            int lineNumber = 0;
            Contribuyente contribuyente = null;
            // Utilizando File.ReadLines
            foreach (string line in File.ReadLines(filePath, Encoding.Default))
            {
                lineNumber++;

                // Buscar el texto en cada línea
                if (line.Contains(searchText))
                {
                    contribuyente = new Contribuyente();
                    contribuyente= GetContribuyente(line, separador);
                    break; // Cortar el bucle una vez que se encuentre la coincidencia
                }
            }          

            return contribuyente;

        }

        private Contribuyente GetContribuyente(string line, char separador)
        {

            var contribuyente = new Contribuyente();
            try
            {
                if (!string.IsNullOrEmpty(line))
                {
                    string[] data = line.Split(separador);
                    contribuyente.RUC = getInfo(data, 0);
                    contribuyente.RazonSocial = getInfo(data, 1);
                    contribuyente.EstadoContribuyente = getInfo(data, 2);
                    contribuyente.CondicionDomicilio = getInfo(data, 3);
                    contribuyente.Ubigeo = getInfo(data, 4);
                    contribuyente.TipoVia = getInfo(data, 5);
                    contribuyente.NombreVia = getInfo(data, 6);
                    contribuyente.CodigoZona = getInfo(data, 7);
                    contribuyente.TipoZona = getInfo(data, 8);
                    contribuyente.Numero = getInfo(data, 9);
                    contribuyente.Interior = getInfo(data, 10);
                    contribuyente.Lote = getInfo(data, 11);
                    contribuyente.Departamento = getInfo(data, 12);
                    contribuyente.Manzana = getInfo(data, 13);
                    contribuyente.Kilometro = getInfo(data, 14);
                    contribuyente.Texto = line;

                }
            }
            catch (Exception)
            {

                throw;
            }
            return contribuyente;
        }

        private static string getInfo(string[] data, int item)
        {
            string _info = string.Empty;

            if(data != null)
            {
                _info = data[item];
                if(_info=="-")
                    _info = string.Empty;
            }
           

            return _info;
        }

    }


}
