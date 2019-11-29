using System;
using System.Runtime.Serialization;

namespace INSServicios.SISED.Entidades.Models
{
    [DataContract]
    [Serializable]
    public class ClientesModel
    {
        [DataMember]
        public int conCliente { get; set; }
        [DataMember]
        public int conTipoIdentificacion { get; set; }
        [DataMember]
        public string identificacion { get; set; }
        [DataMember]
        public string primerNombre { get; set; }
        [DataMember]
        public string segundoNombre { get; set; }
        [DataMember]
        public string primerApellido { get; set; }
        [DataMember]
        public string segundoApellido { get; set; }
        [DataMember]
        public string numeroTelefono { get; set; }
        [DataMember]
        public bool isEstado { get; set; }
        [DataMember]
        public string idCorreoElectronico { get; set; }
        [DataMember]
        public string correoElectronico { get; set; }
        [DataMember]
        public string clave { get; set; }
        [DataMember]
        public bool isTemp { get; set; }
        [DataMember]
        public int conSistema { get; set; }
        [DataMember]
        public string usrCreacion { get; set; }
        [DataMember]
        public DateTime fecCreacion { get; set; }
        [DataMember]
        public string usrUltimaModificacion { get; set; }
        [DataMember]
        public DateTime fecUltimaModificacion { get; set; }
  

    }
}
