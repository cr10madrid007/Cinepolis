using Cinepolis.Models;
using System;
using System.IO;
using Xamarin.Forms;
namespace Cinepolis
{
    public partial class App : Application
    {
        static bdLogin basedatos;
        public static bdLogin BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new bdLogin(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleDB.db3"));
                }
                return basedatos;
            }
        }
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
