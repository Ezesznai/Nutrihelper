using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NutriHelper
{
    public partial class Form7 : Form
    {
        Propiedades Comida;
        char[] delimiterChars = { ':', 'k' };
        string[] kcal_comidas;
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

        public async void BtnAceptar_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = "INFORMACION NUTRICIONAL DE:";
            Datos.busquedaAPI = txtIntroducirComida.Text;
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
            responseString = "null";
            string busqueda = txtIntroducirComida.Text;

            var http = new HttpClient();

            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Datos.clave_API);

            var valuesRequest = new Dictionary<string, string>
        {
           { "application", "json" },
        };

            var contentRequest = new FormUrlEncodedContent(valuesRequest);

            var responseRequest = await http.PostAsync("https://platform.fatsecret.com/rest/server.api?method=foods.search&search_expression=" + Datos.busquedaAPI + "&format=json", contentRequest);

            var responseRequestString = await responseRequest.Content.ReadAsStringAsync();

            lblBusqueda.Text = "BUSQUEDA: " + Datos.busquedaAPI;
            lblInfoNutri.Text = "INFORMACION NUTRICIONAL DE: " + Datos.busquedaAPI;
            if (responseRequestString == null)
            {
                MessageBox.Show("No se ha encontrado tu comida, prueba con otra");
            }
            else
            {
                Comida = JsonConvert.DeserializeObject<Propiedades>(responseRequestString);

                lblComida1.Text = Comida.foods.food[0].food_name;
                lblComida2.Text = Comida.foods.food[1].food_name;
                lblComida3.Text = Comida.foods.food[2].food_name;
                lblComida4.Text = Comida.foods.food[3].food_name;
                lblComida5.Text = Comida.foods.food[4].food_name;
                lblComida6.Text = Comida.foods.food[5].food_name;
                lblComida7.Text = Comida.foods.food[6].food_name;
                lblComida8.Text = Comida.foods.food[7].food_name;
                lblComida9.Text = Comida.foods.food[8].food_name;
                lblComida10.Text = Comida.foods.food[9].food_name;
            }
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

        private void LblComida1_Click(object sender, EventArgs e)
        {
            lblfood_description.Text = Comida.foods.food[0].food_description;
            kcal_comidas = Comida.foods.food[0].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida2_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[1].food_description;
            kcal_comidas = Comida.foods.food[1].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida3_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[2].food_description;
            kcal_comidas = Comida.foods.food[2].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida4_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[3].food_description;
            kcal_comidas = Comida.foods.food[3].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida5_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[4].food_description;
            kcal_comidas = Comida.foods.food[4].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida6_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[5].food_description;
            kcal_comidas = Comida.foods.food[5].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida7_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[6].food_description;
            kcal_comidas = Comida.foods.food[6].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida8_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[7].food_description;
            kcal_comidas = Comida.foods.food[7].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida9_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[8].food_description;
            kcal_comidas = Comida.foods.food[8].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void LblComida10_Click(object sender, EventArgs e)
        {
            lblInfoNutri.Text = Comida.foods.food[9].food_description;
            kcal_comidas = Comida.foods.food[9].food_description.Split(delimiterChars[0])[1].Split(delimiterChars[1]);
            lblkcal.Text = Convert.ToString(kcal_comidas[0]);
        }

        private void Txtporcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Datos.CantPorcion = Convert.ToDouble(txtporcion.Text);
            lblkcal.Text = Convert.ToString((Convert.ToDouble(kcal_comidas[0]) / 100) * Datos.CantPorcion);
        }

        private void LblIntroducirComida_Click(object sender, EventArgs e)
        {

        }
    }
    public class food
    {
        public string food_description { get; set; }
        public string food_name { get; set; }
    }
    public class foods
    {
        public food[] food { get; set; }
    }
    public class Propiedades
    {
        public foods foods { get; set; }

    }
    public class FoodsResp
    {
        public string food_name { get; set; }
        public string food_type { get; set; }
        public string food_description { get; set; }
    }
}
