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
    public partial class pagarEntrada : ContentPage
    {
        public pagarEntrada(string id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_, string hora_, int[]a)
        {
            InitializeComponent();
            for(int i = 0;i<40; i++)
            {
                if (a[i] != 0)
                {
                    DisplayAlert("a", a[i].ToString(), "ok");
                }
            } 
        }
    }
}