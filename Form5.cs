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
			//lbl_kcalrestante.Text = "Kcal restantes hoy: " + (Datos.kcal - Datos.kcal_hoy);




			db.Open();
			OleDbCommand adapter_desayuno;
			adapter_desayuno = new OleDbCommand("SELECT * FROM Comidas WHERE nombre = '" + Datos.nombre + "' AND tipo = 'desayuno'", db);
			OleDbDataAdapter desayuno = new OleDbDataAdapter(adapter_desayuno);
			DataSet dataset_desayuno = new DataSet();
			desayuno.Fill(dataset_desayuno);
			string info_desayuno = "";
			int kcal_desayuno = 0;
			for (int i = 0; i < dataset_desayuno.Tables[0].Rows.Count; i++)
			{
				string gramos = dataset_desayuno.Tables[0].Rows[i]["gramos"].ToString();
				kcal_desayuno += Convert.ToInt32(dataset_desayuno.Tables[0].Rows[i]["kcal_comida"].ToString());
				string comida = dataset_desayuno.Tables[0].Rows[i]["comida"].ToString();
				info_desayuno += comida + ": " + kcal_desayuno + " calorías, " + gramos + " gramos" + "\n";
				//cmb_desayuno.Items.Add(comida + ": " + kcal_comida + " calorías, " + gramos + " gramos");

			}
			lbl_infodesayuno.Text = info_desayuno;


			OleDbCommand adapter_almuerzo;
			adapter_almuerzo = new OleDbCommand("SELECT * FROM Comidas WHERE nombre = '" + Datos.nombre + "' AND tipo = 'almuerzo'", db);
			OleDbDataAdapter almuerzo = new OleDbDataAdapter(adapter_almuerzo);
			DataSet dataset_almuerzo = new DataSet();
			almuerzo.Fill(dataset_almuerzo);
			string info_almuerzo = "";
			int kcal_almuerzo = 0;
			for (int i = 0; i < dataset_almuerzo.Tables[0].Rows.Count; i++)
			{
				string gramos = dataset_almuerzo.Tables[0].Rows[i]["gramos"].ToString();
				kcal_almuerzo += Convert.ToInt32(dataset_almuerzo.Tables[0].Rows[i]["kcal_comida"].ToString());
				string comida = dataset_almuerzo.Tables[0].Rows[i]["comida"].ToString();
				info_almuerzo += comida + ": " + kcal_almuerzo + " calorías, " + gramos + " gramos" + "\n";

			}
			lbl_infoalmuerzo.Text = info_almuerzo;

			OleDbCommand adapter_snacks;
			adapter_snacks = new OleDbCommand("SELECT * FROM Comidas WHERE nombre = '" + Datos.nombre + "' AND tipo = 'snack'", db);
			OleDbDataAdapter snacks = new OleDbDataAdapter(adapter_snacks);
			DataSet dataset_snacks = new DataSet();
			snacks.Fill(dataset_snacks);
			string info_snacks = "";
			int kcal_snacks = 0;
			for (int i = 0; i < dataset_snacks.Tables[0].Rows.Count; i++)
			{
				string gramos = dataset_snacks.Tables[0].Rows[i]["gramos"].ToString();
				kcal_snacks += Convert.ToInt32(dataset_snacks.Tables[0].Rows[i]["kcal_comida"].ToString());
				string comida = dataset_snacks.Tables[0].Rows[i]["comida"].ToString();
				info_snacks += comida + ": " + kcal_snacks + " calorías, " + gramos + " gramos" + "\n";

			}
			lbl_infosnacks.Text = info_snacks;


			OleDbCommand adapter_cena;
			adapter_cena = new OleDbCommand("SELECT * FROM Comidas WHERE nombre = '" + Datos.nombre + "' AND tipo = 'cena'", db);
			OleDbDataAdapter cena = new OleDbDataAdapter(adapter_cena);
			DataSet dataset_cena = new DataSet();
			cena.Fill(dataset_cena);
			string info_cena = "";
			int kcal_cena = 0;
			for (int i = 0; i < dataset_cena.Tables[0].Rows.Count; i++)
			{
				string gramos = dataset_cena.Tables[0].Rows[i]["gramos"].ToString();
				kcal_cena += Convert.ToInt32(dataset_cena.Tables[0].Rows[i]["kcal_comida"].ToString());
				string comida = dataset_cena.Tables[0].Rows[i]["comida"].ToString();
				info_cena += comida + ": " + kcal_cena + " calorías, " + gramos + " gramos" + "\n";

			}
			lbl_infocena.Text = info_cena;


			OleDbCommand adapter_kcal;
			adapter_kcal = new OleDbCommand("SELECT * FROM Usuario WHERE nombre = '" + Datos.nombre + "'", db);
			OleDbDataAdapter kcal = new OleDbDataAdapter(adapter_kcal);
			DataSet dataset_kcal = new DataSet();
			kcal.Fill(dataset_kcal);
			int calorias = 0;
			calorias = Convert.ToInt32(dataset_kcal.Tables[0].Rows[0]["kcal"].ToString());
			lbl_kcalrestante.Text = Convert.ToString(calorias);


			int num_desayuno = Convert.ToInt32(kcal_desayuno);
			int num_almuerzo = Convert.ToInt32(kcal_almuerzo);
			int num_snacks = Convert.ToInt32(kcal_snacks);
			int num_cena = Convert.ToInt32(kcal_cena);

			int kcal_hoy = (num_desayuno + num_almuerzo + num_snacks + num_cena);
		    lbl_kcalconsumidas.Text = Convert.ToString(kcal_hoy);
			int total = (kcal_hoy - calorias);
			if (kcal_hoy >= calorias)
			 { 
			lbl_total.Text = "+" + Convert.ToString(total);
				 }
			else
			{
				lbl_total.Text = "-" + Convert.ToString(total);
			}
			





			/*if (dataset_desayuno.Tables[0].Rows.Count != 0 && dataset_desayuno.Tables[0].Rows[0]["tipo"].ToString()== Datos.tipo)
			{
				lbl_infodesayunocomida.Text = dataset_desayuno.Tables[0].Rows[0]["comida"].ToString();
				lbl_infodesayunogramos.Text = dataset_desayuno.Tables[0].Rows[0]["gramos"].ToString();
				lbl_infodesayunogramos.Text = dataset_desayuno.Tables[0].Rows[0]["kcal_comida"].ToString();
				

			}
		*/
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

		private void Button5_Click_1(object sender, EventArgs e)
		{

		}

		private void Cmb_desayuno_SelectedIndexChanged(object sender, EventArgs e)
		{
			//cmb_desayuno.Items.Add(lbl_infocena.Text);
			//cmb_desayuno.Items.Insert(0, lbl_infodesayuno.Text);
		}

		private void Button5_Click_2(object sender, EventArgs e)
		{

		}

		private void Btn_resumendesayuno_Click(object sender, EventArgs e)
		{
			if (lbl_infodesayuno.Visible) lbl_infodesayuno.Visible = false;
			else lbl_infodesayuno.Visible = true;
		}

		private void Lbl_resumenalmuerzo_Click(object sender, EventArgs e)
		{
			if (lbl_infoalmuerzo.Visible) lbl_infoalmuerzo.Visible = false;
			else lbl_infoalmuerzo.Visible = true;
		}

		private void Lbl_resumensnacks_Click(object sender, EventArgs e)
		{
			if (lbl_infosnacks.Visible) lbl_infosnacks.Visible = false;
			else lbl_infosnacks.Visible = true;
		}

		private void Lbl_resumencena_Click(object sender, EventArgs e)
		{
			if (lbl_infocena.Visible) lbl_infocena.Visible = false;
			else lbl_infocena.Visible = true;
		}

		private void Btn_almuerzo_Click(object sender, EventArgs e)
		{
			if (lbl_infoalmuerzo.Visible) lbl_infoalmuerzo.Visible = false;
			else lbl_infoalmuerzo.Visible = true;
		}

		private void Btn_snacks_Click(object sender, EventArgs e)
		{
			if (lbl_infosnacks.Visible) lbl_infosnacks.Visible = false;
			else lbl_infosnacks.Visible = true;
		}

		private void Btn_cena_Click(object sender, EventArgs e)
		{
			if (lbl_infocena.Visible) lbl_infocena.Visible = false;
			else lbl_infocena.Visible = true;
		}
	}
	public class RequestToken
    {
        public string access_token { get; set; }
    }
}

