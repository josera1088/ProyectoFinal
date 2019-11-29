using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Proyecto_Final.Models
{
    [DataContract]
    [Serializable]
    class RespuestasAPIModel
    {
        //{"Codigo":"0","Resultado":"Ya existe un candidato"}
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Resultado { get; set; }

        [DataMember]
        public decimal ResultadoD { get; set; }
    }
}
