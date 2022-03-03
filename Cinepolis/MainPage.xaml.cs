using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cinepolis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblCrearFunc();
            lblOlvidoFunc();
        }
        private void btnContinuar_Clicked(object sender, EventArgs e)
        {

        }


        void  lblCrearFunc()
        {
            lblCrear.GestureRecognizers.Add(new TapGestureRecognizer()
            {

                Command = new Command(() => {
                    var pagina = new aUsuarios.RegistrarUsuario();

                    Navigation.PushAsync(pagina);
                })
            });

        }


        void lblOlvidoFunc()
        {
            lblOlvido.GestureRecognizers.Add(new TapGestureRecognizer()
            {

                Command = new Command(() => {
                    var pagina = new aUsuarios.OlvidoContraseña();

                    Navigation.PushAsync(pagina);
                })
            });
        }



    }
}
