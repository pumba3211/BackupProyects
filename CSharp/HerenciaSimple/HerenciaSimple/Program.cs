using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseMejorada oCalculadoraMejorada = new ClaseMejorada
            {
                a = 5,
                b = 4
            };  
            Console.WriteLine("La suma es: "+oCalculadoraMejorada.ResultadoSumatoria());
            Console.WriteLine("La resta es: " + oCalculadoraMejorada.ResultadoResta());
            Console.WriteLine("La division es: " + oCalculadoraMejorada.ResultadoDivision());
            Console.WriteLine("La multiplicacion es: " + oCalculadoraMejorada.ResultadoMultiplicacion());
            Console.ReadLine();
        }
    }
}
