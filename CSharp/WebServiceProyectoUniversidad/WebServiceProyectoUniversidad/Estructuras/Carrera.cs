using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Carrera
    {
        [DataMember]
        public int ID_Carrera { set; get; }

        [DataMember]
        public string Nombre_Carrera { set; get; }

        [DataMember]
        public int Estado { set; get; }
    }
}