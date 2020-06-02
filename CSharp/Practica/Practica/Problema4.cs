using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema4
    {
        int[] arreglo = new int[] { };
        int mayor = 0;

        public int[] getArreglo()
        {
            return arreglo;
        }

        public void setArreglo(int[] arreglo)
        {
            this.arreglo = arreglo;
        }
        public int CalcularMayor()
        {
            return (arreglo.Max());
        }
        
                                        
    }
}
