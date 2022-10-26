using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace NutriHelper
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (Datos.Comida == '1')
            {
                lblTipoComida.Text = "Desayuno";
            }
            if (Datos.Comida == '2')
            {
                lblTipoComida.Text = "Almuerzo";
            }
            if (Datos.Comida == '3')
            {
                lblTipoComida.Text = "Cena";
            }
            if (Datos.Comida == '4')
            {
                lblTipoComida.Text = "Snacks";
            }
        }

        private void LblBusqueda_Click(object sender, EventArgs e)
        {

        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
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

            string busqueda = txtIntroducirComida.Text;

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, "https://platform.fatsecret.com/rest/server.api");
            req.Headers.Add("Bearer", Datos.clave_API);
            //req.Headers.Add("Content-Type", "application/json");
            req.Headers.Add("Parameters", "method=foods.search&search_expression=" + busqueda  + "&format=json");
            values = new Dictionary<string, string>
                {
                   { "scope", "basic" },
                   { "grant_type", ""+busqueda+""}
                };
            content = new FormUrlEncodedContent(values);
            
            req.Content = content;

            client = new HttpClient();
            HttpResponseMessage resp = await client.SendAsync(req);


            lblBusqueda.Text = "BUSQUEDA : " + busqueda ;
            responseString = await response.Content.ReadAsStringAsync();
          FoodsResp resultado = JsonConvert. DeserializeObject<FoodsResp>(responseString);
            Console.WriteLine(resultado.food_name);

            lblInfoNutri.Text = Convert.ToString(resultado);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form5 Pantalla_principal = new Form5();
            this.Hide();
            Pantalla_principal.Show();
            
        }

        private void LblInfoNutri_Click(object sender, EventArgs e)
        {

        }
    }

    public class FoodsResp
    {
        public string food_name { get; set; }
        public string food_type { get; set; }
        public string food_description { get; set; }
    }
}
