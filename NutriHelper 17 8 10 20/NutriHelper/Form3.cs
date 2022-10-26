using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriHelper
{
    public partial class Form3 : Form
    {
        OleDbConnection db;
        string objetivo;



        public Form3()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_confirmar_Click(object sender, EventArgs e)

        {
            db.Open();
            OleDbCommand objetivos;
            objetivos = new OleDbCommand("UPDATE Usuarios SET objetivo = ('" + objetivo + "')", db);
            objetivos.Connection = db;
            objetivos.ExecuteNonQuery();
            db.Close();

            /*
            OleDbCommand adapter_peso;
            new OleDbCommand("SELECT FROM Usuarios WHERE peso = " + Datos.peso + "", db);
            OleDbDataAdapter peso = new OleDbDataAdapter(adapter_peso);
            DataSet dataset_peso = new DataSet();
            peso.Fill(dataset_peso);

            OleDbCommand adapter_altura;
            adapter_altura = new OleDbCommand("SELECT altura FROM Usuarios WHERE altura = " + Datos.altura + "", db);
            adapter_altura.Connection = db;
            adapter_altura.ExecuteNonQuery();
            OleDbDataAdapter altura = new OleDbDataAdapter(adapter_altura);
            DataSet dataset_altura = new DataSet();
            altura.Fill(dataset_altura);


            OleDbCommand adapter_edad;
            adapter_edad = new OleDbCommand("SELECT FROM Usuarios WHERE edad = " + Datos.edad + "", db);
            OleDbDataAdapter edad = new OleDbDataAdapter(adapter_edad);
            DataSet dataset_edad = new DataSet();
            edad.Fill(dataset_edad);

            OleDbCommand adapter_actividad;
            adapter_actividad = new OleDbCommand("SELECT FROM Usuarios WHERE actividad = " + Datos.actividad + "", db);
            OleDbDataAdapter actividad = new OleDbDataAdapter(adapter_actividad);
            DataSet dataset_actividad = new DataSet();
            actividad.Fill(dataset_actividad);
            db.Close();
            */



            if (objetivo == "bajar peso" && Datos.sexo == "hombre")
            {
                db.Open();
               Datos.kcal = (66.5 + (13.8 * Datos.peso) + (5 * Datos.altura) - (6.8 * Datos.edad)) * Datos.actividad - 300;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();

            }
            else if (objetivo == "perder grasa" && Datos.sexo == "hombre")
            {
                db.Open();
                Datos.kcal = (66.5 + (13.8 * Datos.peso) + (5 * Datos.altura) - (6.8 * Datos.edad)) * Datos.actividad - 500;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();

            }
            else if (objetivo == "mantener peso" && Datos.sexo == "hombre")
            {
                db.Open();
                Datos.kcal = (66.5 + (13.8 * Datos.peso) + (5 * Datos.altura) - (6.8 * Datos.edad)) * Datos.actividad;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();

            }
            else if (objetivo == "subir peso" && Datos.sexo == "hombre")
            {
                db.Open();
                Datos.kcal = (66.5 + (13.8 * Datos.peso) + (5 * Datos.altura) - (6.8 * Datos.edad)) * Datos.actividad + 300;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();
            }
            else if (objetivo == "ganar masa" && Datos.sexo == "hombre")
            {
                db.Open();
                Datos.kcal = (66.5 + (13.8 * Datos.peso) + (5 * Datos.altura) - (6.8 * Datos.edad)) * Datos.actividad + 500;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();
            }
            else if (objetivo == "bajar peso" && Datos.sexo == "mujer")
            {
                db.Open();
                Datos.kcal = (655 + (9.6 * Datos.peso) + (1.85 * Datos.altura) - (4.7 * Datos.edad) * Datos.actividad) - 300;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();
            }
            else if (objetivo == "perder grasa" && Datos.sexo == "mujer")
            {
                db.Open();
                Datos.kcal =(655 + (9.6 * Datos.peso) + (1.85 * Datos.altura) - (4.7 * Datos.edad) * Datos.actividad) - 500;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();
            }
            else if (objetivo == "mantener peso" && Datos.sexo == "mujer")
            {
                db.Open();
                Datos.kcal = (655 + (9.6 * Datos.peso) + (1.85 * Datos.altura) - (4.7 * Datos.edad) * Datos.actividad);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();

            }
            else if (objetivo == "subir peso" && Datos.sexo == "mujer")
            {
                db.Open();
                Datos.kcal = (655 + (9.6 * Datos.peso) + (1.85 * Datos.altura) - (4.7 * Datos.edad) * Datos.actividad) +300;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();
            }
            else if (objetivo == "ganar masa" && Datos.sexo == "mujer")
            {
                db.Open();
                Datos.kcal = (655 + (9.6 * Datos.peso) + (1.85 * Datos.altura) - (4.7 * Datos.edad) * Datos.actividad) +500;
                Datos.kcal = Math.Round(Datos.kcal, 0);
                MessageBox.Show(Datos.kcal + "");
                OleDbCommand kcal;
                kcal = new OleDbCommand("UPDATE Usuarios SET kcal = " + Datos.kcal + " WHERE nombre ='" + Datos.nombre + "'");
                kcal.Connection = db;
                kcal.ExecuteNonQuery();
                db.Close();
            }

          


            Form4 datos_usuario = new Form4();
            datos_usuario.Show();
            this.Hide();
        }


        private void Btn_musculo_Click(object sender, EventArgs e)
        {
            objetivo = "subir peso";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            objetivo = "perder grasa";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            objetivo = "ganar masa";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            objetivo = "bajar peso";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\47653943\\Documents\\GitHub\\nutrihelper 11 8\\Nutrihelper\\nutrihelperDB.accdb";

        }

        private void Btn_mantener_Click_1(object sender, EventArgs e)
        {
            
                objetivo = "mantener peso";
            
        }
    }
    }

