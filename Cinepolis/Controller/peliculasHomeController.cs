using Cinepolis.Clases;
using Cinepolis.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
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
                var response = await client.GetAsync(direccion + "Cinepolis/tclientes/vistas/vPeliculasHomeTegus.php");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapaises = JsonConvert.DeserializeObject<List<ApiPeliculasHome.ph>>(contenido);
                }
            }
            return listapaises;
        }



        public async static Task<List<ApiPeliculasHome.ph>> ObtenerPeliculasHomeSPS()
        {
            var direc = new ruta();
            String direccion = direc.ruta_();
            List<ApiPeliculasHome.ph> listapaises = new List<ApiPeliculasHome.ph>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(direccion + "Cinepolis/tclientes/vistas/vPeliculasHomeSPS.php");
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
