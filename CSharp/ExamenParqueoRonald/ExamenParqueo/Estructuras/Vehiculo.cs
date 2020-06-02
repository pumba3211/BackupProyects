using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExamenParqueo.Estructuras
{
    [DataContract]
    public class Vehiculo
    {
        [DataMember]
        public string Matricula { set; get; }

        [DataMember]
        public int Cedula { set; get; }

        [DataMember]
        public string Color { set; get; }

        [DataMember]
        public string Marca { set; get; }
    }
}