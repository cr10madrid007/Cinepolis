using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Forms.VideoPlayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.vMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class reproductor : ContentPage
    {
        public reproductor(string video_)
        {
            InitializeComponent();
            UriVideoSource uriVideoSurce = new UriVideoSource()
            {
                Uri = video_
            };

            videoPlayer.Source = uriVideoSurce;
        }

        async void CloseButton_Clicked(System.Object sender, System.EventArgs e)
        {
            videoPlayer.Pause();
            await Navigation.PopAsync();
        }

        void videoPlayer_PlayCompletion(System.Object sender, System.EventArgs e)
        {
            //Do what ever you want 

        }
    }
}