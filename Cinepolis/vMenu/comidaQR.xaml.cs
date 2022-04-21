using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Cinepolis.vMenu
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class comidaQR : ContentPage
    {
        ZXingBarcodeImageView qr;
        public comidaQR(string id)
        {
            InitializeComponent();
            generar(id);
            msj();
        }

        async private void btnSalir_Clicked(object sender, EventArgs e)
        {
            var pagina = new home();
            await Navigation.PushAsync(pagina);
        }
        async void msj()
        {
            await DisplayAlert("Felicidades", "Compra realizada con exito", "OK");
        }
        async void generar(string id)
        {
            var direc = new Clases.ruta();
            String direccion = direc.ruta_();


            qr = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            qr.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            qr.BarcodeOptions.Width = 500;
            qr.BarcodeOptions.Height = 500;
            qr.BarcodeValue = direccion + "Cinepolis/PaginaWeb/body/accionesPHP/vCompra1.php?id=" + id;
            stQR.Children.Add(qr);
        }
    }
}