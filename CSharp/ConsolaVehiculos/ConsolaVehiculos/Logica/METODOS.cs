using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.Logica
{
    class METODOS:IMetodos
    {
        public string Matricula
        {
            set;
            get;
        }

        public int Latitud
        {
            set;
            get;
        }

        public int Longitud
        {
            set;
            get;
        }

        public void generarCoordenas()
        {
            throw new NotImplementedException();
        }

        public void RegenerarCordenaPrincipal()
        {
            throw new NotImplementedException();
        }
    }
}
