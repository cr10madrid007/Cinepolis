using System;
using System.Collections.Generic;
using System.Text;
using Cinepolis.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Cinepolis.Clases;
namespace Cinepolis.Controller
{
    public class peliculasHomeController
    {
        public async static Task<List<ApiPeliculasHome.ph>> ObtenerPeliculasHomeTegus()
        {
            var direc = new ruta();
            String direccion = direc.ruta_();
            List<ApiPeliculasHome.ph> listapaises = new List<ApiPeliculasHome.ph>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(direccion+ "Cinepolis/tclientes/vistas/vPeliculasHomeTegus.php");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapaises = JsonConvert.DeserializeObject<List<ApiPeliculasHome.ph>>(contenido);
                }
            }
            return listapaises;
        }
    }
}
