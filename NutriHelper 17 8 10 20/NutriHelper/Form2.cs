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
using System.Data.OleDb;


namespace NutriHelper
{
    public partial class Form2 : Form



    {
        OleDbConnection bd;

        public Form2()
        {
            InitializeComponent();







        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_avanzar_Click(object sender, EventArgs e)
        {
            
            if (txt_nombre.Text == "" || txt_altura.Text == "" || txt_peso.Text == "" || txt_edad.Text == "" || cmb_sexo.SelectedIndex == -1 || cmb_actividad.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todas las casillas para poder avanzar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                string nombre = txt_nombre.Text;
                int edad = Convert.ToInt16(txt_edad.Text);
                int altura = Convert.ToInt16(txt_altura.Text);
                float peso = Convert.ToSingle(txt_peso.Text);
                Datos.metros = Datos.altura / 100;
                string contraseña = txt_contraseña.Text;

                //bd.Open();
                //OleDbCommand info;
                //info = new OleDbCommand("INSTERT INTO usuario (nombre, sexo, contraseña, peso, altura, edad, actividad) VALUES ('" + nombre + "',)('" + contraseña + "',)('" + peso + "',)('" + altura + "',)('" + edad + "')");
                //info.Connection = bd;
                //info.ExecuteNonQuery();
                //bd.Close();
                Form3 objetivos = new Form3();
                objetivos.Show();
                this.Hide();
            }


         

           



            //while (Datos.nombre == "" || (Datos.edad >= 0 && Datos.edad < 150)|| (Datos.altura > 0 && Datos.altura < 250)|| (Datos.peso > 0 && Datos.peso < 700))
            

            
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

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_edad_Click(object sender, EventArgs e)
        {

        }

        private void Txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //bd = new OleDbConnection();
            //bd.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = NutrihelperDB.accdb";

        }
    }
}
