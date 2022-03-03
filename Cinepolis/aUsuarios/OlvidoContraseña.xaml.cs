using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.aUsuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OlvidoContraseña : ContentPage
    {
        public OlvidoContraseña()
        {
            InitializeComponent();
        }

        private async void btnContinuar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                await DisplayAlert("Error", "Es necesario llenar el campos", "OK");
            }
            else
            {
                var pagina = new ComprobarCodigo(txtCorreo.Text);

                await Navigation.PushAsync(pagina);
            }

        }
    }
}