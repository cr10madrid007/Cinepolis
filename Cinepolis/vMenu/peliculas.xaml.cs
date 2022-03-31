using Cinepolis.Controller;
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
    public partial class peliculas : ContentPage
    {
        public peliculas()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await peliculasHomeController.ObtenerPeliculasHomeTegus();
        }

        private void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}