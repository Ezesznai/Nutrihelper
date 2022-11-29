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
    public partial class Form8 : Form
    {
        OleDbConnection db;
		bool show;
        public Form8()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            db = new OleDbConnection();
			db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\47653943\\Downloads\\Nutrihelper-main\Nutrihelperfinal\\NutriHelper\\nutrihelperDB.accdb";
		}

        private void Button1_Click(object sender, EventArgs e)
        {
            db.Open();
            OleDbCommand adapter_nombre;
            adapter_nombre = new OleDbCommand("SELECT * FROM Usuario WHERE nombre = '" + txt_nombre.Text + "' AND password = '" + txt_contraseña.Text + "'", db);
            OleDbDataAdapter nombre = new OleDbDataAdapter(adapter_nombre);
            DataSet dataset_nombre = new DataSet();
            nombre.Fill(dataset_nombre);
            if (dataset_nombre.Tables[0].Rows.Count != 0)
            {
                Datos.nombre = txt_nombre.Text;
                Form5 menu = new Form5();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }
            db.Close();




            /*db.Open();
            OleDbCommand adapter_nombre;
            adapter_nombre = new OleDbCommand("SELECT * FROM Usuarios WHERE nombre = '" + txt_nombre.Text + "' AND password = '" + txt_contraseña.Text + "'", db);
            OleDbDataAdapter nombre = new OleDbDataAdapter(adapter_nombre);
            DataSet dataset_nombre = new DataSet();
            nombre.Fill(dataset_nombre);
            if (dataset_nombre.Tables[0].Rows.Count != 0)
            {
                Datos.nombre = txt_nombre.Text
            Form5 menu = new Form5();
                menu.Show();
                this.Hide();
            /*}
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }
            db.Close();*/

                
           


        }

        private void Lbl_contraseña_Click(object sender, EventArgs e)
        {

        }

        private void Txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

		private void PictureBox2_Click(object sender, EventArgs e)
		{
			show = true;
			pb_ocultarcontraseña.BringToFront();
			txt_contraseña.PasswordChar = '\0';
		}

		private void Pb_mostrarcontraseña_Click(object sender, EventArgs e)
		{
			show = false;
			if (show == false)
				pb_mostrarcontraseña.BringToFront();
			txt_contraseña.PasswordChar = '*';
		}
	}
}
