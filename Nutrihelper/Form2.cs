using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace NutriHelper
{
    public partial class Form2 : Form



    {
        public Form2()
        {
            InitializeComponent();







        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btn_avanzar_Click(object sender, EventArgs e)
        {
            Datos.nombre = txt_nombre.Text;
            Datos.edad = Convert.ToInt16(txt_edad.Text);
            Datos.altura = Convert.ToInt16(txt_altura.Text);
            Datos.peso = Convert.ToSingle(txt_peso.Text);
            Datos.sexo = cmb_sexo.Text;
            Datos.actividad = Convert.ToSingle(cmb_actividad.Text);
            Datos.actividad = 0;

            Form3 objetivos = new Form3();
            objetivos.Show();
            this.Hide();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datos.sexo = cmb_sexo.SelectedItem.ToString();
            if (cmb_sexo.SelectedIndex == 0)
            {
                Datos.sexo = "hombre";
            }
            else
            {
                Datos.sexo = "mujer";
            }

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Datos.actividad = cmb_actividad.SelectedIndex;

            if (cmb_actividad.SelectedIndex == 0)
            {

                Datos.actividad = 1.2;

            }
            else if (cmb_actividad.SelectedIndex == 1)
            {
                Datos.actividad = 1.375;
            }
            else if (cmb_actividad.SelectedIndex == 2)
            {
                Datos.actividad = 1.55;
            }
            else if (cmb_actividad.SelectedIndex == 3)
            {
                Datos.actividad = 1.725;
            }


            else
            {
                Datos.actividad = 1.9;
            }
        



            }
    private void Txt_edad_TextChanged(object sender, EventArgs e)
    {

    }

}
}
