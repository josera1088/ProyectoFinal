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
    public partial class Nuevo_Caso : ContentPage
    {
        public string NombreUsuario { get; set; }
        public Nuevo_Caso()
        {
            InitializeComponent();
            btInicio.Clicked += BtInicio_Clicked;
        }

        private void BtInicio_Clicked(object sender, EventArgs e)
        {
            try
            {
                string vlcNombreMetodo = "CrearEncabezadoOrden";
                string url = "http://portal.insurancecr.net:8082/INSServicios.SISEDServicio/api/OrdenAvaluoController/" + vlcNombreMetodo;
                AvaluoModel avaluo = new AvaluoModel();
                avaluo.conCED = Convert.ToInt32(NombreUsuario);
                avaluo.conEstado = 1;
                avaluo.SITESA = false;
                avaluo.NumCaso = numeroCaso.Text.ToUpper().Trim();
                avaluo.Placa = Placa.Text.ToUpper().Trim();
                avaluo.usrCreacion = "jramireza@insservicios.com";

                avaluo.Clientes.conCliente = 0;
                avaluo.Clientes.identificacion = identificacion.Text.Trim();
                avaluo.Clientes.primerNombre = Nombre.Text.Trim();
                avaluo.Clientes.segundoNombre = "";
                avaluo.Clientes.primerApellido = Apellido.Text.Trim();
                avaluo.Clientes.segundoApellido = "";
                avaluo.Clientes.numeroTelefono = Telefono.Text.Trim();
                avaluo.Clientes.correoElectronico = Correo.Text.Trim().ToLower();
                avaluo.TipoVehiculo.conTipoVehiculo = 2;

                var json = JsonConvert.SerializeObject(avaluo);

                int respuestasAPI = LlamarAPI(json, url);
                if (respuestasAPI == 1)
                {
                    DisplayAlert("Atención", "Caso ingresado con exito", "Aceptar");
                    Navigation.PushAsync(new Viesta() { NombreUsuario = NombreUsuario });
                }
                else
                {
                    DisplayAlert("Atención", "Error al crear el caso", "Aceptar");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int LlamarAPI(object obj, string pvcUrl)
        {
            RespuestasAPIModel respuestasAPIModel = new RespuestasAPIModel();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(pvcUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(obj);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    respuestasAPIModel = JsonConvert.DeserializeObject<RespuestasAPIModel>(result);
                }
            }
            catch (Exception ex)
            {
                respuestasAPIModel.Codigo = 0;
            }


            return respuestasAPIModel.Codigo;
        }
    }
}
