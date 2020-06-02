using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WsRecursosHumanos.Estructuras
{
    [DataContract]
    public class Empleado
    {
        [DataMember]
        public int Cedula { set; get; }

        [DataMember]
        public string Nombre { set; get; }

        [DataMember]
        public int Edad { set; get; }

        [DataMember]
        public string Puesto { set; get; }
    }
}
    
