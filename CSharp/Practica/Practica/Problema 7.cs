using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Problema_7
    {
        char letra;
        public char getletra()
        {
            return letra;
        }

        public void setLetra(char letra)
        {
            this.letra = letra;
        }
        public String Calificacion()
        {
            String resultado = "";
            if (letra == 'A')
            {
                resultado="Estudiante Exelente";
            }
            else
            {
                resultado = "Estudiante Promedio";
            }
            return resultado;
        }
        

    }
}
