using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceProyectoUniversidad.Estructuras
{
    [DataContract]
    public class Adminstrador
    {
        [DataMember]
        public string Username { set; get; }

        [DataMember]
        public string password { set; get; }

        
    }
}