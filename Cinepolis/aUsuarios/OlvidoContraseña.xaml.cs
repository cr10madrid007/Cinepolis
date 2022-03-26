using Cinepolis.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.aUsuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OlvidoContraseña : ContentPage
    {
        String correo = "", codigo = "", a="";
        public OlvidoContraseña()
        {
            InitializeComponent();
        }

        private async void btnContinuar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                await DisplayAlert("Error", "Es necesario llenar los campos", "OK");
            }
            else
            {/* 
                var pagina = new ComprobarCodigo(txtCorreo.Text);

                await Navigation.PushAsync(pagina);
                */

               
                btnContinuar.IsVisible = false;
                fCorreo.IsVisible = false;

                fCodigo.IsVisible = true;
                btnVerificar.IsVisible = true;



                correo = txtCorreo.Text;


                numeroRand();

                
            }

        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtContra.Text))
            {
                await DisplayAlert("Error", "Es necesario llenar los campos", "OK");
            }else
            {

                var direc = new ruta();
                String direccion = direc.ruta_();
                direccion = direccion + "Cinepolis/tclientes/nuevaContra.php";

                MultipartFormDataContent parametros = new MultipartFormDataContent();
                StringContent email = new StringContent(correo);
                StringContent pas = new StringContent(txtContra.Text);
                parametros.Add(email, "correo");
                parametros.Add(pas, "contra");

                using (HttpClient client = new HttpClient())
                {
                    var respuesta = await client.PostAsync(direccion, parametros);

                    Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                    var pagina = new MainPage();

                    await Navigation.PushAsync(pagina);

                }

            }

        }

        private async void btnVerificar_Clicked(object sender, EventArgs e)
        {
            if (txtCodigo.Text == a)
            {
                fCodigo.IsVisible = false;
                btnVerificar.IsVisible = false;

                fContra.IsVisible = true;
                btnActualizar.IsVisible = true;
            }
            else
            {
                await DisplayAlert("Error","Codigo Invalido","OK");
            }

        }


        private async void numeroRand()
        {
            Random rnd = new Random();



            for (uint ctr = 1; ctr <= 1; ctr++)
            {

                a = Convert.ToString(rnd.Next(9999));
            }
            
            var direc = new ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/verificarCorreo.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);
            StringContent code = new StringContent(a);
            parametros.Add(email, "correo");
            parametros.Add(code, "codigo");

            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);
    
            }

        }

    }
}