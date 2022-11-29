using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.OleDb;

namespace NutriHelper
{

	public partial class Form5 : Form
	{
		OleDbConnection db;
		public Form5()
		{
			InitializeComponent();
		}

		private void LblKcalRest_Click(object sender, EventArgs e)
		{

		}

		private void Form5_Load(object sender, EventArgs e)
		{
			db = new OleDbConnection();
			db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\47653943\\Downloads\\Nutrihelper-main\Nutrihelperfinal\\NutriHelper\\nutrihelperDB.accdb";

			DateTime hora = DateTime.Now;
			lbl_hora.Text = hora.ToString("hh:mm");

			Datos.kcal_hoy -= (Datos.kcal_hoy_desayuno + Datos.kcal_hoy_almuerzo + Datos.kcal_hoy_cena + Datos.kcal_hoy_snack);
			lblKcalRest.Text = "Kcal restantes hoy: " + (Datos.kcal - Datos.kcal_hoy);

			
			db.Open();
			OleDbCommand adapter_desayuno;
			adapter_desayuno = new OleDbCommand("SELECT * FROM Comidas WHERE nombre = '" + Datos.nombre + "' AND tipo = '" + Datos.tipo + "'", db);
			OleDbDataAdapter desayuno = new OleDbDataAdapter(adapter_desayuno);
			DataSet dataset_desayuno = new DataSet();
			desayuno.Fill(dataset_desayuno);
			if (dataset_desayuno.Tables[0].Rows.Count != 0)
			{
				lbl_infodesayuno.Text = dataset_desayuno.Tables[0].Rows[0]["comida"].ToString();
			}

		}

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Form6 Infografias = new Form6();
            Infografias.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
			Datos.tipo = "desayuno";
            Form7 Comidas = new Form7();
            Comidas.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
			Datos.tipo = "almuerzo";
			Form7 Comidas = new Form7();
            Comidas.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
			Datos.tipo = "snack";
			Form7 Comidas = new Form7();
            Comidas.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
			Datos.tipo = "cena";
            Form7 Comidas = new Form7();
            Comidas.Show();
            this.Hide();
        }

        async public void Button5_Click(object sender, EventArgs e)
        {/*
            HttpClient client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("282131e23bd6496faa49f2c1d8acb04a:f89ee04e65c241ca800a7a8e073f7ae5");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            var values = new Dictionary<string, string>
{
   { "scope", "basic" },
   { "grant_type", "client_credentials" }
};
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://oauth.fatsecret.com/connect/token", content);

            var responseString = await response.Content.ReadAsStringAsync();

            RequestToken token = JsonConvert.DeserializeObject<RequestToken>(responseString);

            Datos.clave_API = token.access_token;
            lblJWT.Text = Datos.clave_API;            
        */}



        private void Label1_Click(object sender, EventArgs e)
        {

        }

		private void Label1_Click_1(object sender, EventArgs e)
		{
			
		}

		private void Lbl_infodesayuno_Click(object sender, EventArgs e)
		{

		}
	}
	public class RequestToken
    {
        public string access_token { get; set; }
    }
}

