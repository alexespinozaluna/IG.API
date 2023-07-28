using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG.API.Test
{
    public class BuscarTexto
    {
        public async Task Buscar(string filePath, string searchText)
        {
            int lineNumber = 0;
            bool found = false;

            var contribuyente = new Contribuyente();
            // Utilizando File.ReadLines
            foreach (string line in File.ReadLines(filePath,Encoding.Default))
            {
                lineNumber++;

                // Buscar el texto en cada línea
                if (line.Contains(searchText))
                {
                    Console.WriteLine($"El texto '{searchText}' fue encontrado en la línea {lineNumber}: {line}");
                    contribuyente = GetContribuyente(line, '|');
                    found = true;
                    break; // Cortar el bucle una vez que se encuentre la coincidencia
                }
            }
           
            if (!found)
            {
                Console.WriteLine($"El texto '{searchText}' no fue encontrado en el archivo.");
            }           

        }

        private Contribuyente GetContribuyente(string line, char separador)
        {

            var contribuyente = new Contribuyente();
            try
            {
                if (!string.IsNullOrEmpty(line))
                {
                    string[] datos = line.Split(separador);
                    contribuyente.RUC = datos[0];
                    contribuyente.Ubigeo = datos[1];
                    contribuyente.TipoVia = datos[2];
                    contribuyente.NombreVia = datos[3];
                    contribuyente.CodigoZona = datos[4];
                    contribuyente.TipoZona = datos[5];
                    contribuyente.Numero = datos[6];
                    contribuyente.Kilometro = datos[7];
                    contribuyente.Interor = datos[8];
                    contribuyente.Lote = datos[9];
                    contribuyente.Departamento = datos[10];
                    contribuyente.Manzana = datos[11];
                    contribuyente.Texto = line;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return contribuyente;
        }

    }

    
}
