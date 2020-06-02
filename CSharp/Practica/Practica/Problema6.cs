using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema6
    {
        String letra;
        public String getletra()
        {
            return letra;
        }

        public void setLetra(String letra)
        {
            this.letra = letra;
        }
        public String conversion()
        {
            if (letra.ToUpper() != letra)
            {
                letra = letra.ToUpper();
            }
            else
            {
                letra = letra.ToLower();
            }
            return letra + " Conversion Realizada"+"\n";

        }
    }
}
