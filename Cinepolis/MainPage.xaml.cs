using Cinepolis.Clases;
using Cinepolis.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;

namespace Cinepolis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblCrearFunc();
            lblOlvidoFunc();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
           

            try { 
                var datos = await App.BaseDatos.listaempleados();
                int n = datos.Count();
                    if (n == 1)
                    {
                        var pagina = new vMenu.home();
                        await Navigation.PushAsync(pagina);
                    }

            }
            catch (Exception ex)
            {
                var datos = await App.BaseDatos.listaempleados();
                int n = datos.Count();
                if (n == 1)
                {
                    var pagina = new vMenu.home();
                    await Navigation.PushAsync(pagina);
                }
            }


        }
        private async void btnContinuar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCorreo.Text) || String.IsNullOrWhiteSpace(txtContra.Text))
            {
                await DisplayAlert("Error", "Es necesario llenar los campos", "OK");
            }
            else
            {

                var direc = new ruta();
                String direccion = direc.ruta_();
                direccion = direccion + "Cinepolis/tclientes/logIn.php";

                MultipartFormDataContent parametros = new MultipartFormDataContent();
                StringContent email = new StringContent(txtCorreo.Text);
                StringContent pas = new StringContent(txtContra.Text);
                parametros.Add(email, "email");
                parametros.Add(pas, "pass");

                using (HttpClient client = new HttpClient())
                {
                    var respuesta = await client.PostAsync(direccion, parametros);

                    Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);
                    var rs = respuesta.Content.ReadAsStringAsync().Result;


                    if (rs.Equals("NO"))
                    {
                        await DisplayAlert("Error", "Datos Incorrectos", "Ok");
                    }
                    else
                    {

                        var emple = new constructorLogin
                        {
                            nombre = rs,
                            correo = txtCorreo.Text
                        };
                        var resultado = await App.BaseDatos.EmpleadoGuardar(emple);
                        if (resultado != 0)
                        {
                            var pagina = new vMenu.home();
                            await Navigation.PushAsync(pagina);
                        }

                    }

                }

            }
        }


        void lblCrearFunc()
        {
            lblCrear.GestureRecognizers.Add(new TapGestureRecognizer()
            {

                Command = new Command(() =>
                {
                    var pagina = new aUsuarios.RegistrarUsuario();

                    Navigation.PushAsync(pagina);
                })
            });

        }


        void lblOlvidoFunc()
        {
            lblOlvido.GestureRecognizers.Add(new TapGestureRecognizer()
            {

                Command = new Command(() =>
                {
                    var pagina = new aUsuarios.OlvidoContraseña();

                    Navigation.PushAsync(pagina);
                })
            });
        }



    }
}
