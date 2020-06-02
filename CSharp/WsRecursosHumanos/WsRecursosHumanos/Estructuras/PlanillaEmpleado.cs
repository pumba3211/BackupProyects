using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WsRecursosHumanos.Estructuras
{
    [DataContract]
    public class PlanillaEmpleado
    {
        [DataMember]
        public int IDplanilla { set; get; }

        [DataMember]
        public int IDempleado { set; get; }

        [DataMember]
        public double saldo { set; get; }

    }
}