using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class home : ContentPage
    {
        public home()
        {
            InitializeComponent();


        }

        private async void slPelicula_Tapped(object sender, EventArgs e)
        {
            var pagina = new peliculas();
            await Navigation.PushAsync(pagina);
        }

        private void slComida_Tapped(object sender, EventArgs e)
        {

        }

        private void slUbicacion_Tapped(object sender, EventArgs e)
        {

        }

        private void slUsuario_Tapped(object sender, EventArgs e)
        {

        }

        private void slHistorial_Tapped(object sender, EventArgs e)
        {

        }

        private void slSalir_Tapped(object sender, EventArgs e)
        {

        }
    }
}