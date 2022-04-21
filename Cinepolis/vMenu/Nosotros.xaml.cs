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
    public partial class Nosotros : ContentPage
    {
        public Nosotros()
        {
            InitializeComponent();
            string txt = "Cinépolis es una empresa mexicana con el objetivo de crear un verdadero valor de diversión, comodidad y entretenimiento para sus clientes. Fundada en Santa Bárbara en 2020, es líder de la industria cinematográfica y del entretenimiento en Honduras y Latinoamérica. Cinépolis es la cuarta cadena más grande a nivel mundial, la segunda más grande en venta de entradas, la primera en entradas vendidos por sala y la más importante fuera de los Estados Unidos. Además, es el operador de salas VIP más grande del mundo.";
            lblTexto.Text = txt;

            string txt2 = "Siempre a la vanguardia tecnológica en el sector cinematográfico, Cinépolis introdujo en México el concepto de salas múltiplex tipo estadio, pantallas IMAX® en salas comerciales, salas VIP, salas Junior®, el programa de lealtad Club Cinépolis®, la forma de pago CineCash® y los servicios de reserva y compra de boletos Cineticket®, también es la primera cadena en Latinoamérica en implementar la numeración de butacas dentro sus salas y es pionera en América al introducir la tecnología 4DX para vivir la experiencia en cuarta dimensión, con butacas con movimiento, aroma y efectos de luz y viento..";
            lblTexto2.Text = txt2;
        }
    }
}