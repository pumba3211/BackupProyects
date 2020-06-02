using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica_1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            bool validacionDeMenu=false;
            int[] numeros=new int[] {};
            Opciones opciones = Opciones.Default;
            while (!validacionDeMenu)
            {

                Console.WriteLine(" ");
                Console.WriteLine("El menú es el siguiente");
                Console.WriteLine("1 Digite la cantidad de numeros");
                Console.WriteLine("2 Imprimir el arreglo");
                Console.WriteLine("3 Sumatoria");
                Console.WriteLine("4 Resta");
                Console.WriteLine("5 Multiplicacion");
                Console.WriteLine("6 Division");
                Console.WriteLine("7 Salir");
                Console.WriteLine(" ");
                foreach (var item in Console.ReadLine().Split())
                {
                    if (!char.IsDigit(item[0]))
                    {
                        Console.WriteLine("Gracias,Siga participando");
                        Thread.Sleep(2000);
                        Environment.Exit();
                    }
                }
              
         
                /*if (char.IsDigit(Console.ReadLine()[0]))
                {*/
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    opciones = (Opciones)opcion;
                    Operaciones operaciones;
                    switch (opciones)
                    {
                        case Opciones.Default:
                            break;

                        case Opciones.Opcion1:
                            Console.WriteLine("Digite el numero del arreglo");
                            numeros = new int[Convert.ToInt32(Console.ReadLine())];
                            for (int i = 0; i < numeros.Length; i++)
                            {
                                numeros[i] = i+1;
                            }
                            break;

                        case Opciones.Opcion2:
                            foreach (var numero in numeros)
                            {
                                Console.WriteLine(" " + numero + " "); 
                            }
                            break;

                        case Opciones.Opcion3:
                            operaciones = new Operaciones();
                            operaciones.Numeros = numeros;
                            Console.WriteLine(operaciones.Suma());
                            break;

                        case Opciones.Opcion4:                          
                            operaciones = new Operaciones();
                            operaciones.Numeros = numeros;
                            Console.WriteLine(operaciones.Resta());
                            break;

                        case Opciones.Opcion5:                    
                            operaciones = new Operaciones();
                            operaciones.Numeros = numeros;
                            Console.WriteLine(operaciones.Multiplicacion());
                            break;
                        case Opciones.Opcion6:                           
                            operaciones = new Operaciones();
                            operaciones.Numeros = numeros;
                            Console.WriteLine(operaciones.Division());
                            break;
                        case Opciones.Salir:
                            break;
                        default:
                            break;
                    }
                    
                /*}
                else
                {
                    Console.WriteLine("Opcion incorrecta");
                    //Espera 2 segundos como un timer 
                    Thread.Sleep(2000);
                    //Cierra lo que se esta ejecutando
                    Environment.Exit(0);
                } */
            }
            }
      
     enum Opciones
        {
            Default,
            Opcion1,
            Opcion2,
            Opcion3,
            Opcion4,
            Opcion5,
            Opcion6,
            Salir
        }
    }
}
    

