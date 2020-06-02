using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Grupo_Entero
    {
        [DataMember]
        public int ID_Grupo { set; get; }

        [DataMember]
        public int ID_Carrera { set; get; }

        [DataMember]
        public string Nombre_Carrera { set; get; }

        [DataMember]
        public int ID_Profesor { set; get; }

        [DataMember]
        public string Nombre{ set; get; }

        [DataMember]
        public int ID_Aula{ set; get; }

        [DataMember]
        public string Nombre_Aula { set; get; }

    }
}