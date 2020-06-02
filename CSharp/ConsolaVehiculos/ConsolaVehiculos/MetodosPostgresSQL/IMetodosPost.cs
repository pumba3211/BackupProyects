using ConsolaVehiculos.Estructuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.MetodosPostgresSQL
{
    public interface IMetodosPost
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }
        void InserarCoordenas();
        List<Coordena> TraerCoordenas();
    }
}
