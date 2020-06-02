using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    
    public class Problema3

    {
        int[] arreglo = new int[]{};

        public int[] getArreglo()
        {
            return arreglo;
        }

        public void setArreglo(int[] arreglo)
        {
            this.arreglo = arreglo;
        }

        public int resultado()
        {
            int suma=0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 0)
                {
                    suma = suma + 1;
                }
            }
            return suma;
        }
    }
}
