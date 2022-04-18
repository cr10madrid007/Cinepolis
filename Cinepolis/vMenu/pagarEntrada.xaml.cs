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
    public partial class pagarEntrada : ContentPage
    {
        public pagarEntrada(string id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_, string hora_, int[]a)
        {
            string sillaMostrar = "Numero de sillas: ";
            int contadorSilla = 0;

           
            InitializeComponent();


            for(int i = 0;i<40; i++)
            {
                if (a[i] != 0)
                {
                    //DisplayAlert("a", a[i].ToString(), "ok");
                    sillaMostrar = sillaMostrar + a[i].ToString() + ", ";
                    contadorSilla++;
                }
            }
            sillaMostrar = sillaMostrar + "\nTotal de sillas a comprar: (" + contadorSilla.ToString() + ")";

            var correo= datoCorreo();
            var nombreC = datoNombre();
            
            string correo2 = correo.Result;
            //DisplayAlert("t", correo2, "ok");
            ubicacion(correo2);
            
            lblPelicula.Text = nombre_;
            lblFecha.Text = DateTime.Now.ToString();
            lblHora.Text = hora_;
            
            lblDuracion.Text = duracion_;
            lblSillas.Text = sillaMostrar;
            lblComprador.Text = nombreC.Result;
            lblCorreoComprador.Text = correo.Result;

            int tap = contadorSilla * 100;
            lblTp.Text = "L. "+tap.ToString()+".00";
            
        }


        async Task<string> datoCorreo()
        {
            var datos = await App.BaseDatos.ObtenerCliente();
            var cor = datos.correo;
            return cor;
        }

        async Task<string> datoNombre()
        {
            var datos = await App.BaseDatos.ObtenerCliente();


            return datos.nombre;
        }

        async void ubicacion(string correo)
        {
            

            

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

                lblLugar.Text =location;
            }
        

            
        }

        private void btnAtras_Clicked(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {

        }
    }
}