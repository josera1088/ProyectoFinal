using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Proyecto_Final.Models
{
    [DataContract]
    [Serializable]
    public class CEDModel
    {
        [DataMember]
        public int conCED { get; set; }
        [DataMember]
        public string NombreCED { get; set; }
        [DataMember]
        public string NombreComercial { get; set; }
        [DataMember]
        public string Identificacion { get; set; }
        [DataMember]
        public string CorreoElectronico { get; set; }
        [DataMember]
        public string CuentaBanco { get; set; }
        [DataMember]
        public int Acreedor { get; set; }
        [DataMember]
        public string DireccionFisica { get; set; }
        [DataMember]
        public bool IsTemporal { get; set; }
        [DataMember]
        public bool Estado { get; set; }
        [DataMember]
        public bool IsSinpe { get; set; }
        [DataMember]
        public string Clave { get; set; }
        [DataMember]
        public string TelefonoPrincipal { get; set; }
        [DataMember]
        public string TelefonoSecundario { get; set; }
        [DataMember]
        public DateTime FechaContrato { get; set; }
        [DataMember]
        public string usrCreacion { get; set; }
        [DataMember]
        public DateTime FecCreacion { get; set; }
        [DataMember]
        public string usrUltimaModificacion { get; set; }
        [DataMember]
        public DateTime FecUltimaModificacion { get; set; }
    }
}
