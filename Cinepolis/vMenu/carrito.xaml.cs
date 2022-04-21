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
    public partial class carrito : ContentPage
    {
        int cantidad4 = 0, cantidad1=0, cantidad2 = 0, cantidad3 = 0;
        public carrito()
        {
            InitializeComponent();
        }

        
      
       

        async private void compar_Clicked(object sender, EventArgs e)
        {
            string content = "Usted seleccionó ";
            if (cantidad1 > 0 || cantidad2 > 0 || cantidad3 > 0 || cantidad4 > 0)
            {
                if (cantidad1 > 0)
                {
                    content = content +"," + cantidad1.ToString() + " Combos. Palomitas de maíz + dos refrescos (L. 120 C/u)";
                }

                if (cantidad2 > 0)
                {
                    content = content + "," + cantidad2.ToString() + " Combos. palomitas de maíz + un refresco (L. 95)";
                }

                if (cantidad3 > 0)
                {
                    content = content + "," + cantidad3.ToString() + " Combos.  nachos + un refresco (L. 100)";
                }

                if (cantidad4 > 0)
                {
                    content = content + "," + cantidad4.ToString() + " Refrescos adicionales tiene un costo de 35";
                }
                int tp = (cantidad1 * 120) + (cantidad2 * 95) + (cantidad3 * 100) + (cantidad4 * 35);
                var pagina = new carritoCompra(content, tp);
                await Navigation.PushAsync(pagina);
            }
            else
            {
                await DisplayAlert("Error", "Debe seleccionar algun producto", "ok");
            }
        }

        async private void atras_Clicked(object sender, EventArgs e)
        {
            string content = "Usted seleccionó ";
            if(cantidad1 > 0 || cantidad2 > 0 || cantidad3 > 0 || cantidad4 > 0) { 
                if (cantidad1 > 0)
                {
                    content =content+ cantidad1.ToString() + " Combos. Palomitas de maíz + dos refrescos (L. 120 C/u), ";
                }

                if (cantidad2 > 0)
                {
                    content = content + cantidad2.ToString() + " Combos. palomitas de maíz + un regreso (L. 95), ";
                }

                if (cantidad3 > 0)
                {
                    content = content + cantidad3.ToString() + " Combos.  nachos + un refresco (L. 100), ";
                }

                if (cantidad4 > 0)
                {
                    content = content + cantidad4.ToString() + " Refrescos adicionales tiene un costo de 35, ";
                }
                int tp= (cantidad1 * 120) + (cantidad2 * 95) + (cantidad3 * 100) + (cantidad4 * 35);
                await DisplayAlert("Carrito", content+"Su total a pagar es "+tp.ToString(),"OK");
            }
            else
            {
                await DisplayAlert("Error", "Debe seleccionar algun producto", "ok");
            }
        }
        private void sliderCb1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            cantidad1 = Convert.ToInt32(sliderCb1.Value);
            cantidadCb1.Text = "Cantidad: " + cantidad1.ToString();
        }
        private void sliderCb2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            cantidad2 = Convert.ToInt32(sliderCb2.Value);
            cantidadCb2.Text = "Cantidad: " + cantidad2.ToString();
        }

        private void sliderCb3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            cantidad3 = Convert.ToInt32(sliderCb3.Value);
            cantidadCb3.Text = "Cantidad: " + cantidad3.ToString();
        }
        private void sliderCb4_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            cantidad4 = Convert.ToInt32(sliderCb4.Value);
            cantidadCb4.Text = "Cantidad: " + cantidad4.ToString();
        }

    }
}