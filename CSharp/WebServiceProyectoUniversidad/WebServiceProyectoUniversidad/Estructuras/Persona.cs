using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Persona
    {
        [DataMember]
        public int Cedula { set; get; }

        [DataMember]
        public string Nombre { set; get; }

        [DataMember]
        public string Apellidos { set; get; }
    }
}