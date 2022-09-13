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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
       
        
    

       

        private void Lbl_felicidades_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_kcal_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Datos.kcal = Math.Round(Datos.kcal, 0);
            lbl_kcal.Text = "deberias consumir "+ Datos.kcal+  " Kcal de forma diaria";
           
            
            }
        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Form5 Pantalla_principal = new Form5())
            {
                Pantalla_principal.Show();
            }
            this.Hide();
        }
    }
}
