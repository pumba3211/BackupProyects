using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVotaciones.Estructura
{
    public class Periodo
    {
        public string ID { set; get; }//Identificador del periodo
        public string AñoInicio { set; get; }//Año en el que periodo inicia
        public string AñoFinal { set; get; }//Año en el que el periodo termina
        public string Uso { set; get; }//Se comprueba si el periodo se va a usar
    }
}
