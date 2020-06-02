using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExamenParqueo.Estructuras
{
    [DataContract]
    public class Factura
    {
        [DataMember]
        public string Matricula { set; get; }

        [DataMember]
        public DateTime Fecha_ingreso { set; get; }

        [DataMember]
        public DateTime Fecha_salida { set; get; }

        [DataMember]
        public double Costo_Hora { set; get; }

        [DataMember]
        public int N_factura { set; get; }
    }
}