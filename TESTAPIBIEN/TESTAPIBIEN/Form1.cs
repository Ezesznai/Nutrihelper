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
using RestSharp;
using System.Net;
using System.IO;

namespace TESTAPIBIEN
{

    public partial class Form1 : Form
    {
        Dictionary<string, string> values;
        string url = "https://platform.fatsecret.com/rest/server.api";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Proceso_Click(object sender, EventArgs e)
        {
            Datos.Comida = txtIntroducirComida.Text;

            /*var client = new RestClient("https://api.apilayer.com/spoonacular/food/products/search?query={" + Datos.Comida + "}");

            var request = new RestRequest("https://api.apilayer.com/spoonacular/food/products/search?query={"+Datos.Comida+"}", Method.Get);
            request.AddHeader("apikey", "wWAYkxj46OStvFGV1AOAnzKaFJGmw2J6");
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            lbltester.Text = response.Content;*/
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

            var responseRequest = await http.PostAsync("https://platform.fatsecret.com/rest/server.api?method=foods.search&search_expression=" + Datos.Comida + "&format=json", contentRequest);

            var responseRequestString = await responseRequest.Content.ReadAsStringAsync();

            lbltester.Text = Convert.ToString(responseRequestString);
            Propiedades Comida = JsonConvert.DeserializeObject<Propiedades>(responseRequestString);
            lblCalorias.Text = Comida.foods.food[0].food_name;
            //Hacer un split para separar las calories del food_description, asi hacer los calculos con las medidas de las comidas
            
            
            /*HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
            req.Headers.Add("Bearer", Datos.clave_API);
            req.Headers.Add("Parameters", "method=foods.search&search_expression=" + busqueda + "&format=json");
            values = new Dictionary<string, string>
                {
                   { "scope", "basic" },
                   { "grant_type", "client_credentials"}
                };
            content = new FormUrlEncodedContent(values);

            req.Content = content;

            client = new HttpClient();
            HttpResponseMessage resp = await client.SendAsync(req);


            responseString = await response.Content.ReadAsStringAsync();
            FoodsResp resultado = JsonConvert.DeserializeObject<FoodsResp>(responseString);
            Console.WriteLine(resultado.food_name);
            */

        }


        private void TxtIntroducirComida_TextChanged(object sender, EventArgs e)
        {

        }

        public class FoodsResp
        {
            public string food_name { get; set; }
            public string food_type { get; set; }
            public string food_description { get; set; }
        }

        public class RequestToken
        {
            public string access_token { get; set; }
        }
        //{foods: {food: [{food_description: "hola"}]}}
        public class food
        {
            public string food_description { get; set;  }
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

        private void Lbltester_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //string resultado = await GetHttp();     
            //lbltester.Text = resultado;
        }
        /*public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            req.Headers.Add("Bearer", Datos.clave_API);
            req.Headers.Add("Parameters", "method=foods.search&search_expression=" + busqueda + "&format=json");
            values = new Dictionary<string, string>
                {
                   { "scope", "basic" },
                   { "grant_type", "client_credentials"}
                };
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }*/

    }
}

    
