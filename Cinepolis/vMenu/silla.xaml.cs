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
    public partial class silla : ContentPage
    {
        int cbtn1 = 0, cbtn2 = 0, cbtn3 = 0, cbtn4 = 0, cbtn5 = 0;
        int cbtn6 = 0, cbtn7 = 0, cbtn8 = 0, cbtn9 = 0, cbtn10 = 0;
        int cbtn11 = 0, cbtn12 = 0, cbtn13 = 0, cbtn14 = 0, cbtn15 = 0;
        int cbtn16 = 0, cbtn17 = 0, cbtn18 = 0, cbtn19 = 0, cbtn20 = 0;
        int cbtn21 = 0, cbtn22 = 0, cbtn23 = 0, cbtn24 = 0, cbtn25 = 0;
        int cbtn26 = 0, cbtn27 = 0, cbtn28 = 0, cbtn29 = 0, cbtn30 = 0;
        int cbtn31 = 0, cbtn32 = 0, cbtn33 = 0, cbtn34 = 0, cbtn35 = 0;
        int cbtn36 = 0, cbtn37 = 0, cbtn38 = 0, cbtn39 = 0, cbtn40 = 0;

        int contador = 0;
        public silla(string id_, string nombre_, string synopsis_, string anio_, string clasificacion_, string genero_, string director_, string duracion_, string video_, string banner_,string hora_)
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if(cbtn1==0)
            {
                btn1.BackgroundColor = Color.Green;
                cbtn1 = 1;
                contador++;
            }else
            {
                btn1.BackgroundColor = Color.Default;
                cbtn1 = 0;
                contador--;
            }

            contadorF();
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (cbtn2 == 0)
            {
                btn2.BackgroundColor = Color.Green;
                cbtn2 = 1;
                contador++;
            }
            else
            {
                btn2.BackgroundColor = Color.Default;
                cbtn2 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (cbtn3 == 0)
            {
                btn3.BackgroundColor = Color.Green;
                cbtn3 = 1;
                contador++;
            }
            else
            {
                btn3.BackgroundColor = Color.Default;
                cbtn3 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (cbtn4 == 0)
            {
                btn4.BackgroundColor = Color.Green;
                cbtn4 = 1;
                contador++;
            }
            else
            {
                btn4.BackgroundColor = Color.Default;
                cbtn4 = 0;
                contador--;
            }
            contadorF();
        }

        
        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (cbtn5 == 0)
            {
                btn5.BackgroundColor = Color.Green;
                cbtn5 = 1;
                contador++;
            }
            else
            {
                btn5.BackgroundColor = Color.Default;
                cbtn5 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (cbtn6 == 0)
            {
                btn6.BackgroundColor = Color.Green;
                cbtn6 = 1;
                contador++;
            }
            else
            {
                btn6.BackgroundColor = Color.Default;
                cbtn6 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (cbtn7 == 0)
            {
                btn7.BackgroundColor = Color.Green;
                cbtn7 = 1;
                contador++;
            }
            else
            {
                btn7.BackgroundColor = Color.Default;
                cbtn7 = 0;
                contador--;
            }
            contadorF();
        }


        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (cbtn8 == 0)
            {
                btn8.BackgroundColor = Color.Green;
                cbtn8 = 1;
                contador++;
            }
            else
            {
                btn8.BackgroundColor = Color.Default;
                cbtn8 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (cbtn9 == 0)
            {
                btn9.BackgroundColor = Color.Green;
                cbtn9 = 1;
                contador++;
            }
            else
            {
                btn9.BackgroundColor = Color.Default;
                cbtn9 = 0;
                contador--;
            }
            contadorF();
        }

        private void btnAtras_Clicked(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {

        }

        private void btn10_Clicked(object sender, EventArgs e)
        {
            if (cbtn10 == 0)
            {
                btn10.BackgroundColor = Color.Green;
                cbtn10 = 1;
                contador++;
            }
            else
            {
                btn10.BackgroundColor = Color.Default;
                cbtn10 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn11_Clicked(object sender, EventArgs e)
        {
            if (cbtn11 == 0)
            {
                btn11.BackgroundColor = Color.Green;
                cbtn11 = 1;
                contador++;
            }
            else
            {
                btn11.BackgroundColor = Color.Default;
                cbtn11 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn12_Clicked(object sender, EventArgs e)
        {
            if (cbtn12 == 0)
            {
                btn12.BackgroundColor = Color.Green;
                cbtn12 = 1;
                contador++;
            }
            else
            {
                btn12.BackgroundColor = Color.Default;
                cbtn12 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn13_Clicked(object sender, EventArgs e)
        {
            if (cbtn13 == 0)
            {
                btn13.BackgroundColor = Color.Green;
                cbtn13 = 1;
                contador++;
            }
            else
            {
                btn13.BackgroundColor = Color.Default;
                cbtn13 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn14_Clicked(object sender, EventArgs e)
        {
            if (cbtn14 == 0)
            {
                btn14.BackgroundColor = Color.Green;
                cbtn14 = 1;
                contador++;
            }
            else
            {
                btn14.BackgroundColor = Color.Default;
                cbtn14 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn15_Clicked(object sender, EventArgs e)
        {
            if (cbtn15 == 0)
            {
                btn15.BackgroundColor = Color.Green;
                cbtn15 = 1;
                contador++;
            }
            else
            {
                btn15.BackgroundColor = Color.Default;
                cbtn15 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn16_Clicked(object sender, EventArgs e)
        {
            if (cbtn16 == 0)
            {
                btn16.BackgroundColor = Color.Green;
                cbtn16 = 1;
                contador++;
            }
            else
            {
                btn16.BackgroundColor = Color.Default;
                cbtn16 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn17_Clicked(object sender, EventArgs e)
        {
            if (cbtn17 == 0)
            {
                btn17.BackgroundColor = Color.Green;
                cbtn17 = 1;
                contador++;
            }
            else
            {
                btn17.BackgroundColor = Color.Default;
                cbtn17 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn18_Clicked(object sender, EventArgs e)
        {
            if (cbtn18 == 0)
            {
                btn18.BackgroundColor = Color.Green;
                cbtn18 = 1;
                contador++;
            }
            else
            {
                btn18.BackgroundColor = Color.Default;
                cbtn18 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn19_Clicked(object sender, EventArgs e)
        {
            if (cbtn19 == 0)
            {
                btn19.BackgroundColor = Color.Green;
                cbtn19 = 1;
                contador++;
            }
            else
            {
                btn19.BackgroundColor = Color.Default;
                cbtn19 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn20_Clicked(object sender, EventArgs e)
        {
            if (cbtn20 == 0)
            {
                btn20.BackgroundColor = Color.Green;
                cbtn20 = 1;
                contador++;
            }
            else
            {
                btn20.BackgroundColor = Color.Default;
                cbtn20 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn21_Clicked(object sender, EventArgs e)
        {
            if (cbtn21 == 0)
            {
                btn21.BackgroundColor = Color.Green;
                cbtn21 = 1;
                contador++;
            }
            else
            {
                btn21.BackgroundColor = Color.Default;
                cbtn21 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn22_Clicked(object sender, EventArgs e)
        {
            if (cbtn22 == 0)
            {
                btn22.BackgroundColor = Color.Green;
                cbtn22 = 1;
                contador++;
            }
            else
            {
                btn22.BackgroundColor = Color.Default;
                cbtn22 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn23_Clicked(object sender, EventArgs e)
        {
            if (cbtn23 == 0)
            {
                btn23.BackgroundColor = Color.Green;
                cbtn23 = 1;
                contador++;
            }
            else
            {
                btn23.BackgroundColor = Color.Default;
                cbtn23 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn24_Clicked(object sender, EventArgs e)
        {
            if (cbtn24 == 0)
            {
                btn24.BackgroundColor = Color.Green;
                cbtn24 = 1;
                contador++;
            }
            else
            {
                btn24.BackgroundColor = Color.Default;
                cbtn24 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn25_Clicked(object sender, EventArgs e)
        {
            if (cbtn25 == 0)
            {
                btn25.BackgroundColor = Color.Green;
                cbtn25 = 1;
                contador++;
            }
            else
            {
                btn25.BackgroundColor = Color.Default;
                cbtn25 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn26_Clicked(object sender, EventArgs e)
        {
            if (cbtn26 == 0)
            {
                btn26.BackgroundColor = Color.Green;
                cbtn26 = 1;
                contador++;
            }
            else
            {
                btn26.BackgroundColor = Color.Default;
                cbtn26 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn27_Clicked(object sender, EventArgs e)
        {
            if (cbtn27 == 0)
            {
                btn27.BackgroundColor = Color.Green;
                cbtn27 = 1;
                contador++;
            }
            else
            {
                btn27.BackgroundColor = Color.Default;
                cbtn27 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn28_Clicked(object sender, EventArgs e)
        {
            if (cbtn28 == 0)
            {
                btn28.BackgroundColor = Color.Green;
                cbtn28 = 1;
                contador++;
            }
            else
            {
                btn28.BackgroundColor = Color.Default;
                cbtn28 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn29_Clicked(object sender, EventArgs e)
        {
            if (cbtn29 == 0)
            {
                btn29.BackgroundColor = Color.Green;
                cbtn29 = 1;
                contador++;
            }
            else
            {
                btn29.BackgroundColor = Color.Default;
                cbtn29 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn30_Clicked(object sender, EventArgs e)
        {
            if (cbtn30 == 0)
            {
                btn30.BackgroundColor = Color.Green;
                cbtn30 = 1;
                contador++;
            }
            else
            {
                btn30.BackgroundColor = Color.Default;
                cbtn30 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn31_Clicked(object sender, EventArgs e)
        {
            if (cbtn31 == 0)
            {
                btn31.BackgroundColor = Color.Green;
                cbtn31 = 1;
                contador++;
            }
            else
            {
                btn31.BackgroundColor = Color.Default;
                cbtn31 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn32_Clicked(object sender, EventArgs e)
        {
            if (cbtn32 == 0)
            {
                btn32.BackgroundColor = Color.Green;
                cbtn32 = 1;
                contador++;
            }
            else
            {
                btn32.BackgroundColor = Color.Default;
                cbtn32 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn33_Clicked(object sender, EventArgs e)
        {
            if (cbtn33 == 0)
            {
                btn33.BackgroundColor = Color.Green;
                cbtn33 = 1;
                contador++;
            }
            else
            {
                btn33.BackgroundColor = Color.Default;
                cbtn33 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn34_Clicked(object sender, EventArgs e)
        {
            if (cbtn34 == 0)
            {
                btn34.BackgroundColor = Color.Green;
                cbtn34 = 1;
                contador++;
            }
            else
            {
                btn34.BackgroundColor = Color.Default;
                cbtn34 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn35_Clicked(object sender, EventArgs e)
        {
            if (cbtn35 == 0)
            {
                btn35.BackgroundColor = Color.Green;
                cbtn35 = 1;
                contador++;
            }
            else
            {
                btn35.BackgroundColor = Color.Default;
                cbtn35 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn36_Clicked(object sender, EventArgs e)
        {
            if (cbtn36 == 0)
            {
                btn36.BackgroundColor = Color.Green;
                cbtn36 = 1;
                contador++;
            }
            else
            {
                btn36.BackgroundColor = Color.Default;
                cbtn36 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn37_Clicked(object sender, EventArgs e)
        {
            if (cbtn37 == 0)
            {
                btn37.BackgroundColor = Color.Green;
                cbtn37 = 1;
                contador++;
            }
            else
            {
                btn37.BackgroundColor = Color.Default;
                cbtn37 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn38_Clicked(object sender, EventArgs e)
        {
            if (cbtn38 == 0)
            {
                btn38.BackgroundColor = Color.Green;
                cbtn38 = 1;
                contador++;
            }
            else
            {
                btn38.BackgroundColor = Color.Default;
                cbtn38 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn39_Clicked(object sender, EventArgs e)
        {
            if (cbtn39 == 0)
            {
                btn39.BackgroundColor = Color.Green;
                cbtn39 = 1;
                contador++;
            }
            else
            {
                btn39.BackgroundColor = Color.Default;
                cbtn39 = 0;
                contador--;
            }
            contadorF();
        }

        private void btn40_Clicked(object sender, EventArgs e)
        {
            if (cbtn40 == 0)
            {
                btn40.BackgroundColor = Color.Green;
                cbtn40 = 1;
                contador++;
            }
            else
            {
                btn40.BackgroundColor = Color.Default;
                cbtn40 = 0;
                contador--;
            }
            contadorF();
        }

        void contadorF()
        {
            lblCantidad.Text = "Asientos seleccionados: " + contador;
        }
    }
}