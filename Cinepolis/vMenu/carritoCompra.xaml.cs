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
    public partial class carritoCompra : ContentPage
    {
        string correoG = "", targ="";
        public carritoCompra(string cont, int tp)
        {
            InitializeComponent();
            datoCorreo();
            datoNombre();
            
            ubicacion();
            
            
            lblFecha.Text = DateTime.Now.ToString();
            lblGolosinas.Text = cont;
            lblTp.Text = tp.ToString();

        }

        private async void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            comprobar();
        }

        async void datoCorreo()
        {
            var datos = await App.BaseDatos.ObtenerCliente();
            var cor = datos.correo;
            correoG= datos.correo.ToString();
            lblCorreoComprador.Text=datos.correo.ToString();
            
        }

        async void datoNombre()
        {
            var datos = await App.BaseDatos.ObtenerCliente();


            lblComprador.Text= datos.nombre.ToString();
        }

        async void subirCompra(string tarjeta_)
        {
            
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/insertarCompra.php";
            string dato = lblGolosinas.Text + " y su total pagado es de L. " + lblTp.Text + ".00";
            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(lblCorreoComprador.Text);
            StringContent idP = new StringContent("0");
            StringContent descripcion = new StringContent(lblGolosinas.Text);
            StringContent lugar = new StringContent(lblLugar.Text);
            StringContent tap = new StringContent(lblTp.Text);
            StringContent tarjeta = new StringContent(tarjeta_);

            parametros.Add(email, "correoComprador");
            parametros.Add(idP, "idPelicula");
            parametros.Add(descripcion, "descripcion");
            parametros.Add(lugar, "lugar");
            parametros.Add(tap, "tap");
            parametros.Add(tarjeta, "tarjeta");

            var nt = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                nt = respuesta.Content.ReadAsStringAsync().Result;
                correo(dato);
                var pagina = new comidaQR(nt);
                await Navigation.PushAsync(pagina);

            }
        }

        async void tar()
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/consultaClienteTarjeta.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(lblCorreoComprador.Text);

            parametros.Add(email, "correo");

            var nt = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                nt = respuesta.Content.ReadAsStringAsync().Result;
                subirCompra(nt);
            }
        }

            async void ubicacion()
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/consultaClientesCorreo.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correoG);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

                if(location.Equals("San Pedro Sula")) {

                    lblLugar.Text = location;
                } else
                {
                    lblLugar.Text = "Tegucigalpa";
                }


            }

            



        }

        async void comprobar()
        {
            try
            {
                var direc = new Clases.ruta();
                String direccion = direc.ruta_();
                direccion = direccion + "Cinepolis/tclientes/consultaClienteTarjeta.php";

                MultipartFormDataContent parametros = new MultipartFormDataContent();
                StringContent email = new StringContent(lblCorreoComprador.Text);

                parametros.Add(email, "correo");

                var nt = "";
                using (HttpClient client = new HttpClient())
                {
                    var respuesta = await client.PostAsync(direccion, parametros);

                    Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                    nt = respuesta.Content.ReadAsStringAsync().Result;


                }

                string action = await DisplayActionSheet("¿Desea realizar esta compra?", "Cancel", null, "Si", "No");
                if (action.Equals("Si"))
                {
                    string action2 = await DisplayActionSheet("¿Desea seleccionar la tarjeta con la terminación (" + nt.Substring(12, 4) + ") ?", "Cancel", null, "Si", "No");
                    if (action2.Equals("Si"))
                    {
                        tar();
                    }
                }
            }
            catch (Exception ex) { }
        }


        async void correo(string txt)
        {
            
            string sf = lblFecha.Text;
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/compraPelicula.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(lblCorreoComprador.Text);
            StringContent msj = new StringContent(txt);


            parametros.Add(email, "correo");
            parametros.Add(msj, "msj");


            var nt = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                nt = respuesta.Content.ReadAsStringAsync().Result;


            }
        }
    }
}