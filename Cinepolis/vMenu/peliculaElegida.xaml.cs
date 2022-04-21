using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class peliculaElegida : ContentPage
    {
        string id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, banner__, video__;
        public peliculaElegida(string id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_)
        {
            InitializeComponent();
            imgBanner.Source = banner_;
            lblTitulo.Text = nombre_;
            lblSynopsis.Text = synopsis_;
            lblGenero.Text = genero_;
            lblAño.Text = anio_;
            lblDirector.Text = director_;
            lblDuración.Text = duracion_;
            lblClasificacion.Text = clasificacion_;

            id__ = id_;
            nombre__ = nombre_;
            synopsis__ = synopsis_;
            anio__ = anio_;
            clasificacion__ = clasificacion_;
            genero__ = genero_;
            director__ = director_;
            duracion__ = duracion_;
            banner__ = banner_;
            video__ = video_;



        }

        async private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            var pagina = new horarios(id__, nombre__, synopsis__, anio__, clasificacion__, genero__, director__, duracion__, video__, banner__);
            await Navigation.PushAsync(pagina);
        }

        private async void btnAtras_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new peliculas());
        }

        async private void btnVideo_Clicked(object sender, EventArgs e)
        {
            var pagina = new reproductor(video__);
            await Navigation.PushAsync(pagina);
        }
    }
}