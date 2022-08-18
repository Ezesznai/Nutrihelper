using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NutriHelper
{
    public partial class Form1 : Form
    {
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Btn_Empezar_Click(object sender, EventArgs e)
        {
         
            Form5 Pantalla_principal = new Form5();
            Pantalla_principal.Show();
            this.Hide();
        }

        private void Btn_tengocuenta_Click(object sender, EventArgs e)
        {
            
            Form2 Pantalla_inicial = new Form2();
            Pantalla_inicial.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   }



