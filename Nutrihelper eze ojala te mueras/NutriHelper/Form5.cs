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

namespace NutriHelper
{

    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void LblKcalRest_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Datos.kcal_hoy -= (Datos.kcal_hoy_desayuno + Datos.kcal_hoy_almuerzo + Datos.kcal_hoy_cena + Datos.kcal_hoy_snack);
            lblKcalRest.Text = "Kcal restantes hoy: " + (Datos.kcal - Datos.kcal_hoy);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Form6 Infografias = new Form6();
            Infografias.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Datos.Comida = '1';
            Form7 Comidas = new Form7();
            Comidas.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Datos.Comida = '2';
            Form7 Comidas = new Form7();
            Comidas.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Datos.Comida = '3';
            Form7 Comidas = new Form7();
            Comidas.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Datos.Comida = '4';
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
    }
    public class RequestToken
    {
        public string access_token { get; set; }
    }
}

