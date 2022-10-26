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

        OleDbConnection db;

        public Form1()
        {
            InitializeComponent();
        }



        private void Btn_Empezar_Click(object sender, EventArgs e)
        {
            /*OleDbCommand adapter_nombre;
            adapter_nombre = new OleDbCommand("SELECT nombre FROM Usuarios WHERE nombre =" + Datos.nombre + "", db);
            OleDbDataAdapter nombre = new OleDbDataAdapter(adapter_nombre);
            DataSet dataset_nombre = new DataSet();
            nombre.Fill(dataset_nombre);
            */

            Form8 nombreycontraseña = new Form8();
            nombreycontraseña.Show();
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
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\47653943\\Documents\\GitHub\\nutrihelper 11 8\\Nutrihelper\\nutrihelperDB.accdb";

        }
    }
   }



