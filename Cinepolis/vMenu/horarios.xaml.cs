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
    public partial class horarios : ContentPage
    {
        string id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, banner__, video__;

       

        public horarios(string id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_)
        {
            InitializeComponent();


            id__ = id_;
            nombre__ = nombre_;
            synopsis__ = synopsis_;
            anio__ = anio_;
            clasificacion__ = clasificacion_;
            genero__ = genero_;
            director__ = director_;
            duracion__ = duracion_;
            banner__ = banner_;
            video__ = video_;

            rbCinco.IsVisible = false;
            rbTres.IsVisible = false;
            rbSiete.IsVisible = false;

            horarioFTres();
            horarioFCinco();
            horarioFSiete();
            
        }
        async void horarioFTres()
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/buscarHorario.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent idC = new StringContent(id__);
            StringContent horaC = new StringContent("15:00");
            parametros.Add(idC, "id");
            parametros.Add(horaC, "hora");

            var rsp = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                rsp = respuesta.Content.ReadAsStringAsync().Result;

            }
            if (rsp.Equals("si"))
            {
                rbTres.IsVisible = true;
            }

        }

        async void horarioFCinco()
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/buscarHorario.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent idC = new StringContent(id__);
            StringContent horaC = new StringContent("17:00");
            parametros.Add(idC, "id");
            parametros.Add(horaC, "hora");

            var rsp = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                rsp = respuesta.Content.ReadAsStringAsync().Result;

            }
            if (rsp.Equals("si"))
            {
                rbCinco.IsVisible = true;
            }

        }

        async void horarioFSiete()
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/buscarHorario.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent idC = new StringContent(id__);
            StringContent horaC = new StringContent("19:00");
            parametros.Add(idC, "id");
            parametros.Add(horaC, "hora");

            var rsp = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                rsp = respuesta.Content.ReadAsStringAsync().Result;

            }
            if (rsp.Equals("si"))
            {
                rbSiete.IsVisible = true;
            }

        }

        async private void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void rbSiete_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {   if (rbSiete.IsChecked == true)
            {
                string action = await DisplayActionSheet("¿Desea seleccionar el horario de las 19:00?", "Cancel", null, "Si", "No");
                if (action.Equals("Si"))
                {
                    string hora__ = "19:00";
                    var pagina = new silla(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__, hora__);
                    await Navigation.PushAsync(pagina);
                }
            }
        }

        async private void rbCinco_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rbCinco.IsChecked == true)
            {
                string action = await DisplayActionSheet("¿Desea seleccionar el horario de las 17:00?", "Cancel", null, "Si", "No");
                if (action.Equals("Si"))
                {
                    string hora__ = "17:00";
                    var pagina = new silla(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__, hora__);
                    await Navigation.PushAsync(pagina);
                }
            }
        }

        async private void rbTres_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rbTres.IsChecked == true)
            {
                string action = await DisplayActionSheet("¿Desea seleccionar el horario de las 15:00?", "Cancel", null, "Si", "No");
                if (action.Equals("Si"))
                {
                    string hora__ = "15:00";
                    var pagina = new silla(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__, hora__);
                    await Navigation.PushAsync(pagina);
                }
            }
        }

        


    }
}