using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriHelper
{
    public partial class Form5 : Form
    {
        public Form5()
        {




        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Datos.kcal_hoy -= (Datos.kcal_hoy_desayuno + Datos.kcal_hoy_almuerzo + Datos.kcal_hoy_cena + Datos.kcal_hoy_snack);
            lblKcalRest.Text = "Kcal restantes hoy: " + (Datos.kcal - Datos.kcal_hoy);


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInfografias_Click(object sender, EventArgs e)
        {
            Form6 Infografias = new Form6();
            Infografias.Show();
            this.Hide();
        }

        private void BtnDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");


        }
    }
}  

   