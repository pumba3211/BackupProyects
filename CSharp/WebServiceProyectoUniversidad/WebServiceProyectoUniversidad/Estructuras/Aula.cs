using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Aula
    {
        [DataMember]
        public int ID_Aula { set; get; }

        [DataMember]
        public string Nombre_Aula { set; get; }
    }
}