using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appMecanicaVarela.Estructura
{
   public class Repuesto
    {
       public string Id{set;get;}
       public string Nombre { set; get; }
       public string Modelo { set; get; }
       public string Marca { set; get; }
       public int Cantidad { set; get; }
       public double Precio { set; get; }
       public int Impuesto { set; get; }
       public bool Gravado { set; get; }

    }
}
