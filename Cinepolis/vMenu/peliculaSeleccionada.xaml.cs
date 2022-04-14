using LibVLCSharp.Shared;
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
    public partial class peliculaSeleccionada : ContentPage
    {
        public peliculaSeleccionada(string id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_)
        {
            InitializeComponent();
            LibVLC _libvlc;
            Core.Initialize();
            _libvlc = new LibVLC();
            MediaPlayer _mediaPlayer = new MediaPlayer(_libvlc)
            {
                Media = new Media(_libvlc, new Uri(video_))
            };

            myVideo.MediaPlayer = _mediaPlayer;

            myVideo.MediaPlayer.Play();
            
            
            lblTitulo.Text = nombre_;
            lblSynopsis.Text = synopsis_;
            lblGenero.Text = genero_;
            lblAño.Text = anio_;
            lblDirector.Text = director_;
            lblDuración.Text = duracion_;
            lblClasificacion.Text = clasificacion_;
            




        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void btnAtras_Clicked(object sender, EventArgs e)
        {
            myVideo.MediaPlayer.Stop();
            await Navigation.PushAsync(new peliculas());
        }
    }
}