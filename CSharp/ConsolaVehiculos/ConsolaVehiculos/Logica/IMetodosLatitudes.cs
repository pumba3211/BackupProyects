using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.Logica
{
    interface IMetodosLatitudes
    {
        string Matricula { set; get; }
        string Latitud { set; get; }
        string Longitud { set; get; }
        void generarCoordenas();
        void RegenerarCordenaPrincipal();
    }
}
