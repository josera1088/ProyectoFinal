using INSServicios.SISED.Entidades;
using INSServicios.SISED.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Proyecto_Final.Models
{
    [DataContract]
    [Serializable]
    public class AvaluoModel
    {
        [DataMember]
        public int conOrdenAvaluo { get; set; }
        [DataMember]
        public int conColaborador { get; set; }
        [DataMember]
        public int conCED { get; set; }
        [DataMember]
        public int conEstado { get; set; }
        [DataMember]
        public string NumCaso { get; set; }
        [DataMember]
        public bool SITESA { get; set; }
        [DataMember]
        public string Placa { get; set; }
        [DataMember]
        public string NombreCliente { get; set; }
        [DataMember]
        public string DescripcionAvaluo { get; set; }
        [DataMember]
        public string CorreoElectronicoCliente { get; set; }
        [DataMember]
        public string usrCreacion { get; set; }
        [DataMember]
        public string codEstadoAvaluo { get; set; }
        [DataMember]
        public string DesMotivoAvaluo { get; set; }
        [DataMember]
        public int conMotivoRec { get; set; }

        [DataMember]
        public int vecesDuplicar { get; set; }

        [DataMember]
        public Boolean ModificarNumCaso { get; set; }
        [DataMember]
        public DateTime FecCreacion { get; set; }
        [DataMember]
        public string usrUltimaModificacion { get; set; }
        [DataMember]
        public DateTime FecUltimaModificacion { get; set; }
        [DataMember]
        public string numFactura { get; set; }
        [DataMember]
        public ClientesModel Clientes = new ClientesModel();
        [DataMember]
        public TipoVehiculoModel TipoVehiculo = new TipoVehiculoModel();

        [DataMember]
        public TipoEstimacionModel tipoEstimacion = new TipoEstimacionModel();

        [DataMember]
        public Object avaluosXML { get; set; }

        [DataMember]
        public string StravaluosXML { get; set; }

        [DataMember]
        public int ConGestorArchivo { get; set; }

        [DataMember]
        public string nomGestorArchivo { get; set; }

        [DataMember]
        public string ArchivoVehiculo { get; set; }
        [DataMember]
        public string ArchivoCotizacion { get; set; }

        [DataMember]
        public string VehiculoEstimacion { get; set; }

        [DataMember]
        public string DesCotizacion { get; set; }

        [DataMember]
        public string numTarifa { get; set; }

        [DataMember]
        public string desTipoEstimacion { get; set; }

        [DataMember]
        public string nomTipoVehiculo { get; set; }

        [DataMember]
        public Boolean isProforma { get; set; }
    }
}
