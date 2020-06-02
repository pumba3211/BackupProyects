using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.Logica
{
    interface IMetodos
    {
        string Matricula { set; get; }
        int Latitud{set;get;}
        int Longitud{set;get;}
        void generarCoordenas();
        void RegenerarCordenaPrincipal();
    }
}
