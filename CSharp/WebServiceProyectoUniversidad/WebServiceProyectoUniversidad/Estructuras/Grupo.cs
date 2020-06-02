using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
[   DataContract]
    public class Grupo
    {
    [DataMember]
        public int ID_Grupo { set; get; }

        [DataMember]
        public int ID_Carrera { set; get; }
       
        [DataMember]
        public int ID_Profesor { set; get; }
       
        [DataMember]
        public int ID_Aula { set; get; }

    }
}