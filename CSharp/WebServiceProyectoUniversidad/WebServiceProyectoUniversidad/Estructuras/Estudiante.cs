using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Estudiante
    {
        [DataMember]
        public int ID_Estudiante{set;get;}

        [DataMember]
        public DateTime Fecha_nacimiento { set; get; }

        [DataMember]
        public int ID_Carrera { set; get; }

        [DataMember]
        public string Direccion { set; get; }
    }
}