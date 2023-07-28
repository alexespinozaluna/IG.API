using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IG.API.Test
{
    internal class Program
    {
        static async Task Main()
        {
            /*
            Console.WriteLine(DateTime.Now);
            string url = "http://www2.sunat.gob.pe/padron_reducido_ruc.zip";
            var RutaGuardar = "D:\\PADRON SUNAT";
            var NombreArchivo = "padron_reducido_ruc.zip";

            DescargarArchivo dow = new DescargarArchivo();//"D:\\PADRON SUNAT\\padron_reducido_ruc.zip";
          await  dow.Descargar(url,RutaGuardar, NombreArchivo);
            Console.WriteLine(DateTime.Now);
            */

            
            Console.WriteLine(DateTime.Now);
            string filePath = "D:\\PADRON SUNAT\\padron_reducido_ruc.txt";
            string searchText = "20505606435|";
            BuscarTexto sear = new BuscarTexto();
           await sear.Buscar(filePath,searchText.ToUpper());

            Console.WriteLine(DateTime.Now);
            

            Console.ReadKey();

        }
    }
}

