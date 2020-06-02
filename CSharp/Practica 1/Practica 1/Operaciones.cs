using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{       
    /// <summary>
    /// Clase operaciones, encargada de las operaciones matématicas 
    /// </summary>
    public class Operaciones
    {
        public int[] Numeros { set; get; }

        public Operaciones()
        {
           
        }
        /// <summary>
        /// Metódo encargadi de  hacer la sumatoria
        /// </summary>
        /// <returns>Retorna el total de la suma </returns>
        public int Suma()
        {
            int contador =0;
            foreach (var numero in Numeros)
            {
                contador = contador + numero;
            }
            return contador;
        }
        /// <summary>
        /// Metodo encargado de hacer la resta
        /// </summary>
        /// <returns>Retorna el total de la resta</returns>
        public int Resta()
        {
            int contador = Numeros[1];
            foreach (var numero in Numeros)
            {
                contador = contador - numero;
            }
            return contador;
        }
        /// <summary>
        /// Metodo encargado de hacer la multiplicacion
        /// </summary>
        /// <returns>Retorna el total de multiplicacion</returns>
        public int Multiplicacion()
        {
            int contador = Numeros[0];
            foreach (var numero in Numeros)
            {
                contador = contador * numero;
            }
            return contador;
        }
        /// <summary>
        /// Metodo encargado de hacer la division
        /// </summary>
        /// <returns>Retorna el total de la division</returns>
        public double Division()
        {
            double contador = Numeros[0];
            foreach (var numero in Numeros)
            {
                contador = contador / numero;
            }
            return contador;
        }
    }
}
