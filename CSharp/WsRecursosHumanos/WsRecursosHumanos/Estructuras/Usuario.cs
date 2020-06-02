using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WsRecursosHumanos.Estructuras
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre{ get; set; }

        [DataMember]
        public string Claver { get; set; }

    }
}