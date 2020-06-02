using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExamenParqueo.Estructuras
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int Cedula { set; get; }

        [DataMember]
        public string nombre_completo { set; get; }

        [DataMember]
        public DateTime Fecha_Nacimiento { set; get; }

        [DataMember]
        public DateTime Fecha_Ingreso { set; get; }
    }
}