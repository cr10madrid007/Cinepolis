using Cinepolis.Controller;
using Cinepolis.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class peliculas : ContentPage
    {
        public peliculas()
        {
            InitializeComponent();
            

        }

       
        protected override async void OnAppearing()
        {
            base.OnAppearing();
           
            
            var datos = await App.BaseDatos.ObtenerCliente();


            var correo = datos.correo;
            
            

            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/consultaClientesCorreo.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

            }
            if (location.Equals("San Pedro Sula"))
            {
                ListaEmpleados.ItemsSource = await peliculasHomeController.ObtenerPeliculasHomeSPS();
            }
            else if (location.Equals("Tegucigalpa"))
            {
                ListaEmpleados.ItemsSource = await peliculasHomeController.ObtenerPeliculasHomeTegus();
            }
            /*
            var emple = new Models.constructorLogin
            {
                codigo = Convert.ToInt32(0)
            };
            var resultado = await App.BaseDatos.EmpleadoBorrar(emple);
            */

        }
        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var d = e.SelectedItem as Models.ApiPeliculasHome.ph;
            var pagina = new peliculaElegida(d.idPelicula, d.nombre, d.synopsis, d.anio, d.clasificacion, d.genero, d.director, d.duracion, d.video, d.banner);
            await Navigation.PushAsync(pagina);

        }
    }
}