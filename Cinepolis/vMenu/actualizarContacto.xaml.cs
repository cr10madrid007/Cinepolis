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
    public partial class actualizarContacto : ContentPage
    {
        string nombre = "", apellido = "", ubicacion = "", tarjeta = "", nombreT = "", fechaT = "", codigoT = "", correo="";
        
        public actualizarContacto()
        {
            InitializeComponent();
            pedirCorreo();
        }

        async private void btnGuardar_Clicked(object sender, EventArgs e)
        {
           
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/actualizar.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);
            StringContent nombre_ = new StringContent(txtNombre.Text);
            StringContent apellido_ = new StringContent(txtApellidos.Text);
            StringContent ubicacion_ = new StringContent(ubicacion);
            StringContent tarjeta_ = new StringContent(txtNumero.Text);
            StringContent nombreT_ = new StringContent(txtNombreT.Text);
            StringContent fecha_ = new StringContent(txtFechaEx.Text);
            StringContent codigo_ = new StringContent(txtCodigo.Text);
            

            parametros.Add(email, "correo");
            parametros.Add(nombre_, "nombre");
            parametros.Add(apellido_, "apellido");
            parametros.Add(ubicacion_, "ubicacion");
            parametros.Add(tarjeta_, "tarjeta");
            parametros.Add(nombreT_, "nombreT");
            parametros.Add(fecha_, "fecha");
            parametros.Add(codigo_, "codigo");
            
            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

                var pagina = new home();
                await Navigation.PushAsync(pagina);
            }
        }

        async private void rbSps_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (rbSps.IsChecked == true)
                {
                    ubicacion = "San pedro Sula";
                }
            }
            catch (Exception ex) { }
        }

        async private void rbTeg_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (rbTeg.IsChecked == true)
                {
                    ubicacion = "Tegucigalpa";
                }
            }
            catch (Exception ex) { }
        }

        async void pedirCorreo()
        {
            var datos = await App.BaseDatos.ObtenerCliente();
            var cor = datos.correo;
            correo= datos.correo;
            nombreF(cor);
            apellidoF(cor);
            ubicacionF(cor);
            tarjetaF(cor);
            nombreTarjetaF(cor);
            fechaF(cor);
            codigoF(cor);
        }

        async void nombreF(String correo)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/nombre.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

                txtNombre.Text = location;
                nombre = location;
            }


        }

        async void apellidoF(string correo)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/apellido.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

                txtApellidos.Text= location;
                apellido= location;
                
            }

        }

        async void ubicacionF(string correo)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/ubicacion.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;
                ubicacion = location;
                if (location.Equals("San Pedro Sula"))
                {
                    rbSps.IsChecked = true;
                }

                else if (location.Equals("Tegucigalpa"))
                {
                    rbTeg.IsChecked = true;
                }
            }

        }

        async void tarjetaF(string correo)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/tarjeta.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

               txtNumero.Text= location;
                tarjeta = location;

            }
        }

        async void nombreTarjetaF(string correo)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/nombreTarjeta.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

                txtNombreT.Text = location;
                nombreT = location;

            }
        }

        async void fechaF(string correo)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/fecha.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

                txtFechaEx.Text = location;
                fechaT = location;
            }
        }

        async void codigoF(string correo)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/datosCliente/codigo.php";

            MultipartFormDataContent parametros = new MultipartFormDataContent();
            StringContent email = new StringContent(correo);

            parametros.Add(email, "correo");

            var location = "";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.PostAsync(direccion, parametros);

                Debug.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

                location = respuesta.Content.ReadAsStringAsync().Result;

                txtCodigo.Text = location;
                codigoT = location;

            }
        }
    }
}