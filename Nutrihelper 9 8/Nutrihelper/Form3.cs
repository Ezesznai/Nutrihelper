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
    public partial class Form3 : Form
    {
        string objetivo;


        public Form3()
        {
            InitializeComponent();
            if (objetivo == "perder grasa" && Datos.sexo == "hombre") {
                
            }


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            if (objetivo == "perder grasa" && Datos.sexo == "mujer")
            {
                Datos.kcal=  ((10 * Datos.peso) + (6.25 * Datos.altura) - (5 * Datos.edad) - 295)*Datos.actividad;
            }
            else if  (objetivo == "mantener peso" && Datos.sexo == "mujer") {

            }
            
         
            Form4 datos_usuario = new Form4();
            datos_usuario.Show();
            this.Hide();
        }

        private void Btn_grasa_Click(object sender, EventArgs e)
        {
        objetivo=("perder grasa");   
           
        }

        private void Btn_mantener_Click(object sender, EventArgs e)
        {
            objetivo = ("mantener peso");
        }

        private void Btn_musculo_Click(object sender, EventArgs e)
        {
            objetivo = ("subir musculo");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
    }

