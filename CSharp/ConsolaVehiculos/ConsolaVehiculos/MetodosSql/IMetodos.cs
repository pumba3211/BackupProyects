using ConsolaVehiculos.Estructuras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.MetodosSql
{
    public interface IMetodos
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        List<Vehiculo> TraerVehiculos();
        void GenerarCoordenas();
        List<Coordena> TraerCoordenas();


    }
}
