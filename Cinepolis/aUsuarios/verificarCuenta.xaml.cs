using Cinepolis.Clases;
using System;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace Cinepolis.aUsuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class verificarCuenta : ContentPage
    {
        String a = "", nombre, apellido, correo, pass, ciudad, nombret, numerot, fechat, codigot;
        public verificarCuenta(String nombre_, String apellido_, String correo_, String pass_, String ciudad_, String nombreT_, String numerot_, String fechat_, String codigot_)
        {
            InitializeComponent();
            generarCodigo(correo_);
            nombre = nombre_;
            apellido = apellido_;
            correo = correo_;
            pass = pass_;

            ciudad = ciudad_;
            nombret = nombreT_;
            numerot = numerot_;
            fechat = fechat_;
            codigot = codigot_;



        }

        private async void btnVerificar_Clicked(object sender, EventArgs e)
        {
            if (txtCodigo.Text == a)
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("nombre", nombre);
                parametros.Add("apellidos", apellido);
                parametros.Add("correo", correo);
                parametros.Add("pass", pass);
                parametros.Add("ubicacion", ciudad);
                parametros.Add("nombreT", nombret);
                parametros.Add("numeroT", numerot);
                parametros.Add("fechaT", fechat);
                parametros.Add("codigo", codigot);

                var direc = new ruta();
                String direccion = direc.ruta_();
                direccion = direccion + "Cinepolis/tclientes/insetClientes.php";
                cliente.UploadValues(direccion, "POST", parametros);

                await DisplayAlert("¡Cuenta creada exitosamente!", "Corre a iniciar sesión para que disfrutes de nosotros.", "IR");

                var pagina = new MainPage();

                await Navigation.PushAsync(pagina);

            }
            else
            {
                await DisplayAlert("Oooops", "Codigo incorrecto.", "OK");
            }

        }


        void generarCodigo(String email)
        {
            Random rnd = new Random();



            for (uint ctr = 1; ctr <= 1; ctr++)
            {

                a = Convert.ToString(rnd.Next(9999));
            }





            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("correo_", email);
            parametros.Add("codigo_", a);

            var direc = new ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/correoRegistro.php";

            cliente.UploadValues(direccion, "POST", parametros);

        }

    }
}