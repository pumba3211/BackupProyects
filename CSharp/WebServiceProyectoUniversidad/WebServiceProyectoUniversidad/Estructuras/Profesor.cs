using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Profesor
    {
        [DataMember]
        public int ID_Profesro { set; get; }

        [DataMember]
        public int ID_Carrera{set;get;}
    }
}