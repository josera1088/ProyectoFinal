using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INSServicios.SISED.Entidades
{
    [DataContract]
    [Serializable]
   public class TipoEstimacionModel
    {
        [DataMember]
        public int conTipoEstimacion { get; set; }
        [DataMember]
        public string codTipoEstimacion { get; set; }
        [DataMember]
        public string desTipoEstimacion { get; set; }
       
    }
}
