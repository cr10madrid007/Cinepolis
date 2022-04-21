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
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();


            var datos = await App.BaseDatos.ObtenerCliente();


            var correo = datos.correo;



            
           
            ListaEmpleados.ItemsSource = await peliculasHomeController.ObtenerPagos(correo.ToString());
           
        }


        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var d = e.SelectedItem as Models.contructorCompra.h;
           
                var pagina = new registroQR(d.idCompra, d.idPelicula);
                await Navigation.PushAsync(pagina);
            
            
            

        }
    }
}