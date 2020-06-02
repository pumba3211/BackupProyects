using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class EstudiantePerson
    {
        [DataMember]
        public int Cedula { set; get; }

        [DataMember]
        public string Nombre { set; get; }

        [DataMember]

        public string Apellidos { set; get; }
        [DataMember]

        public int ID_Estudiante { set; get; }

        [DataMember]
        public DateTime Fecha_nacimiento { set; get; }

        [DataMember]
        public int ID_Carrera { set; get; }
        
        [DataMember]
        public string Direccion { set; get; }
    }
}