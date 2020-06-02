using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WsRecursosHumanos.Estructuras
{
    [DataContract]
    public class Planilla
    {
        [DataMember]
        public int ID { set; get; }

        [DataMember]
        public DateTime Fecha{ set; get; }

        [DataMember]
        public string Nombre{ set; get; }
    }
}