using Newtonsoft.Json;
using Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Viesta : ContentPage
    {
        public string NombreUsuario { get; set; }
        public Viesta()
        {
            InitializeComponent();
        }

        private void CargarAvaluos(string pvcplaca)
        {
            try
            {
                //LimpiarMensaje(lblmensaje);


                List<AvaluoModel> avaluoModels = new List<AvaluoModel>();
                string vlcNombreMetodo = "ObtenerOrdenAvaluoEncabezado";
                string url = "http://portal.insurancecr.net:8082/INSServicios.SISEDServicio/api/OrdenAvaluoController/" + vlcNombreMetodo + "/" + Convert.ToInt32(NombreUsuario) + "/" + "0" + "/" + "01-01-2019" + "/" + "12-12-2019";


                avaluoModels = ObtenerAvaluoEncabezado(url);

                lvDatos.ItemsSource = avaluoModels;
            }
            catch (Exception ex)
            {
                //BitacoraModel model = new BitacoraModel();
                //model.conSistema = Convert.ToInt32(@ConfigurationManager.AppSettings["conSistema"].ToString());
                //model.conTipoSistema = 61;
                //model.descClase = "INSServicios.SISED.Externo.Avaluos";
                //model.descMetodo = "CargarAvaluos";
                //model.descError = ex.StackTrace.ToString(); ;
                //model.descObservacion = ex.Message.ToString();
                //model.usrRegistro = Session["usuarioLogeado"].ToString();
                //LogErrores errores = new LogErrores();
                //errores.IngresarLogError(model);
            }

        }

        public List<AvaluoModel> ObtenerAvaluoEncabezado(string pvcUrl)
        {
            List<AvaluoModel> models = new List<AvaluoModel>();
            try
            {
                string html = RequestAPI(pvcUrl);
                models = JsonConvert.DeserializeObject<List<AvaluoModel>>(html);
                return models;
            }
            catch (Exception ex)
            {
                return models;
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
                //BitacoraModel model = new BitacoraModel();
                //model.conSistema = Convert.ToInt32(@ConfigurationManager.AppSettings["conSistema"].ToString());
                //model.conTipoSistema = 61;
                //model.descClase = "INSServicios.SISED/clsLlamadasAPI/Externo";
                //model.descMetodo = "RequestAPI";
                //model.descError = ex.StackTrace.ToString(); ;
                //model.descObservacion = ex.Message.ToString();
                //model.usrRegistro = "sised@sised.com";
                //LogErrores errores = new LogErrores();
                //errores.IngresarLogError(model);
                return "0";
            }

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CargarAvaluos("");
        }

        private void lvDatos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem;
            AvaluoModel a = (AvaluoModel)myItem;

            var aa = a.NumCaso;

            Navigation.PushAsync(new Ubicar());

        }
    }
}