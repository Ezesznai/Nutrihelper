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
        OleDbConnection db;
       

        public Form2()
        {
            InitializeComponent();
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
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

            if (cmb_actividad.SelectedIndex == 0) {

                Datos.actividad = 1.2f;
            }
            else if (cmb_actividad.SelectedIndex == 1)
            {
                Datos.actividad = 1.375f;
            }
            else if (cmb_actividad.SelectedIndex == 2)
            {
                Datos.actividad = 1.55f;
            }
            else if (cmb_actividad.SelectedIndex == 3)
            {
                Datos.actividad = 1.725f;
            }
            else
            {
                Datos.actividad = 1.9f;
            }
        }

        private void Btn_avanzar_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Text == "" || txt_altura.Text == "" || txt_peso.Text == "" || txt_edad.Text == "" || cmb_sexo.SelectedIndex == -1 || cmb_actividad.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todas las casillas para poder avanzar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                Datos.nombre = txt_nombre.Text;
                Datos.edad = Convert.ToInt32(txt_edad.Text);
                Datos.peso = Convert.ToSingle(txt_peso.Text);
                Datos.metros = Datos.altura / 100;
                Datos.password = txt_contraseña.Text;
                Datos.altura = Convert.ToInt32(txt_altura.Text);

                /*db.Open();
               OleDbCommand nombre_fk;
               nombre_fk = new OleDbCommand("SELECT nombre FROM Usuarios WHERE nombre = '" + Datos.nombre + "'", db);
                

               
              OleDbDataAdapter adapter1 = new OleDbDataAdapter(nombre_fk);
                DataSet dataset_nombre = new DataSet();
                adapter1.Fill(dataset_nombre);
                db.Close();

                if (dataset_nombre.Tables[0].Rows.Count == 0)
                {
                    
                    db.Open();
                    OleDbCommand info;
                    info = new OleDbCommand("INSERT INTO Usuarios (nombre, sexo, [password], peso, altura, edad, actividad) VALUES ('" + Datos.nombre + "', '" + Datos.sexo + "', '" + Datos.password + "', '" + Datos.peso + "', '" + Datos.altura + "', '" + Datos.edad + "', '" + Datos.actividad + "')", db);
                    info.ExecuteNonQuery();
                    db.Close();*/
                    Form3 objetivos = new Form3();
                    objetivos.Show();
                    this.Hide();
                
                //else ()
                {
                    //MessageBox.Show("ese nick ya esta ocupado, pureba con otro");
             
                }
                
            
                
                
              //  db.Open();
              //  OleDbCommand info;
               // info = new OleDbCommand("INSERT INTO Usuarios (nombre, sexo, [password], peso, altura, edad, actividad) VALUES ('" + Datos.nombre +"', '"+ Datos.sexo +"', '" + Datos.password + "', '"+ Datos.peso +"', '"+ Datos.altura +"', '" + Datos.edad + "', '" + Datos.actividad + "')", db);
               // info.ExecuteNonQuery();
              //  db.Close();


            }


         

           



            //while (Datos.nombre == "" || (Datos.edad >= 0 && Datos.edad < 150)|| (Datos.altura > 0 && Datos.altura < 250)|| (Datos.peso > 0 && Datos.peso < 700))
        

            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //db = new OleDbConnection();
            //db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\47653943\\Documents\\GitHub\\nutrihelper 11 8\\Nutrihelper\\nutrihelperDB.accdb";

    }

        private void Txt_altura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    