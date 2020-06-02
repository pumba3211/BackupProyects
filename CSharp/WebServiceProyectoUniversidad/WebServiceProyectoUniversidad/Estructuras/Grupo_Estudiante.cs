using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Grupo_Estudiante
    {
        [DataMember]
        public int N_Registro { set; get; }

        [DataMember]
        public int ID_Grupo { set; get; }

        [DataMember]
        public int ID_Estudiante { set; get; }
    }
}