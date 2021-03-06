using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.aUsuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarUsuario : ContentPage
    {

        String nombre = "", apellido = "", correo = "", contraseña = "", ciudad = "", nombreT = "", numeroT = "", fechaT = "", codigoT = "";
        DateTime ultima;
        private void txtFechaN_DateSelected(object sender, DateChangedEventArgs e)
        {
            ultima = e.NewDate;


        }

        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private async void btnContinuar_Clicked(object sender, EventArgs e)
        {




            obtener();
            int cant = numeroT.Length;

            if (String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(apellido) || String.IsNullOrWhiteSpace(correo) || String.IsNullOrWhiteSpace(contraseña) || String.IsNullOrWhiteSpace(nombreT) || String.IsNullOrWhiteSpace(numeroT) || String.IsNullOrWhiteSpace(fechaT) || String.IsNullOrWhiteSpace(codigoT) || cant !=16)
            {
                await DisplayAlert("Error", "Es necesario llenar todos los campos correctamente.", "OK");
            }
            else
            {
                var pagina = new verificarCuenta(nombre, apellido, correo, contraseña, ciudad, nombreT, numeroT, fechaT, codigoT);

                await Navigation.PushAsync(pagina);
            }

        }


        void obtener()
        {
            nombre = txtNombre.Text;
            apellido = txtApellidos.Text;
            correo = txtCorreo.Text;
            contraseña = txtPass.Text;



            try
            {
                ciudad = txtCiudad.SelectedItem.ToString();
            }
            catch (Exception)
            {

                ciudad = "San Pedro Sula";
            }

            nombreT = txtNombreT.Text;
            numeroT = txtNumero.Text;
            fechaT = txtFechaEx.Text;
            codigoT = txtCodigo.Text;


        }


    }
}