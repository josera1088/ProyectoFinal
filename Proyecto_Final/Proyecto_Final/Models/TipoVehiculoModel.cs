using System;
using System.Runtime.Serialization;

namespace INSServicios.SISED.Entidades.Models
{
    [DataContract]
    [Serializable]
    public class TipoVehiculoModel
    {
        [DataMember]
        public int conTipoVehiculo { get; set; }
        [DataMember]
        public string codTipoVehiculo { get; set; }
        [DataMember]
        public string nomTipoVehiculo { get; set; }
        [DataMember]
        public decimal numTarifa { get; set; }
    }
}
