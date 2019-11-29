using Newtonsoft.Json;
using Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto_Final
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            btInicio.Clicked += BtInicio_Clicked;
        }

        private async void BtInicio_Clicked(object sender, EventArgs e)
        {
            try
            {
                List<CEDModel> CEDModels = new List<CEDModel>();
                using (var httpClient = new HttpClient())
                {
                    string vlcNombreMetodo = "IngresarAlSistema";
                    string url = "http://portal.insurancecr.net:8082/INSServicios.SISEDServicio/api/SISSED/" + vlcNombreMetodo + "/" + txCorreo.Text.ToString() + "/" + txPass.Text.ToString();


                    CEDModels = ObtenerCED(url);

                    if (CEDModels.Count > 0)
                    {
                        await Navigation.PushAsync(new Menu() { NombreUsuario = CEDModels[0].conCED.ToString() });
                    }
                    else
                    {
                        await DisplayAlert("Atención", "Usuario o contraseña incorrectos", "Aceptar");

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public string RequestAPI(string pvcUrl)
        {
            try
            {
                string html = string.Empty;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(pvcUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                return html;
            }
            catch (Exception ex)
            {
                return "0";
            }

        }

        public List<CEDModel> ObtenerCED(string pvcUrl)
        {
            List<CEDModel> models = new List<CEDModel>();
            try
            {
                string html = RequestAPI(pvcUrl);
                models = JsonConvert.DeserializeObject<List<CEDModel>>(html);
                return models;
            }
            catch (Exception ex)
            {
                return models;
            }

        }
    }
}
