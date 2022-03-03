﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Cinepolis.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.aUsuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComprobarCodigo : ContentPage
    {
        String correo_,a;
        public ComprobarCodigo(String correo)
        {
            InitializeComponent();
            correo_ = correo;
            generarCodigo(correo);
        }



        void generarCodigo(String email)
        {
            Random rnd = new Random();



            for (uint ctr = 1; ctr <= 1; ctr++)
            {

                a = Convert.ToString(rnd.Next(9999));
            }





            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("correo_", email);
            parametros.Add("codigo_", a);

            var direc = new ruta();
            String direccion = direc.ruta_();
            direccion = direccion + "Cinepolis/tclientes/correoComprobar.php";

            cliente.UploadValues(direccion, "POST", parametros);

        }

    }
}