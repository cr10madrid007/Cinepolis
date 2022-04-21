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
    public partial class registroQR : ContentPage
    {
        ZXingBarcodeImageView qr;
        public registroQR(string id, string pelicula)
        {
            InitializeComponent();
            generar(id, pelicula);
        }


        async private void btnSalir_Clicked(object sender, EventArgs e)
        {
            var pagina = new home();
            await Navigation.PushAsync(pagina);
        }
        
        async void generar(string id, string code)
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

            if (code.Equals("0")) { 
            qr.BarcodeValue = direccion + "Cinepolis/PaginaWeb/body/accionesPHP/vCompra1.php?id=" + id;
            stQR.Children.Add(qr);
            }
            else
            {
                qr.BarcodeValue = direccion + "Cinepolis/PaginaWeb/body/accionesPHP/vCompra.php?id=" + id;
                stQR.Children.Add(qr);
            }
        }

        async private void btnSalir_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}