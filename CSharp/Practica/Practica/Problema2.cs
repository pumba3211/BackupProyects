using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Problema2
    {
        public int Multiplicacion()
        {
            int multiplo=0;
            for (int i=10;i<20;i++)
            {
                multiplo = multiplo + (i * (i + 1));
            }
            return (multiplo);

        }
    }
}
