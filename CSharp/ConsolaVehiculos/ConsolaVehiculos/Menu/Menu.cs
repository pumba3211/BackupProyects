using ConsolaVehiculos.Estructuras;
using ConsolaVehiculos.MetodosPostgresSQL;
using ConsolaVehiculos.MetodosSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsolaVehiculos.Menu
{
    public class Menu
    {
        static IMetodos ASD = new MetodosSQL();
        public enum opciones
        {
            Default,
            GenerarCoordenas,
            PasarDatosPostgrest,
            Salir
        }
        public void Menuopciones()
        {
            bool validar = true;
            opciones opcionElegida = opciones.Default;
            opciones Comenzar = opciones.GenerarCoordenas;
            opciones Pasar = opciones.PasarDatosPostgrest;
            opciones Salir = opciones.Salir;
            while (validar)
            {
                Console.WriteLine("llllllllllllllllllllllllllllllllllllllllllllllll");
                Console.WriteLine("lll                  Bienvenido              lll");
                Console.WriteLine("lll              ¿Que desea hacer?           lll");
                Console.WriteLine("lll            1 Generar Coordenas           lll");
                Console.WriteLine("lll        2 Pasar Datos a postgressql       lll");
                Console.WriteLine("lll                   3 Salir                lll");
                Console.WriteLine("llllllllllllllllllllllllllllllllllllllllllllllll");
                int opcion = Convert.ToInt32(Console.ReadLine());
                opcionElegida = (opciones)opcion;
                switch (opcionElegida)
                {
                    case opciones.Default:
                        break;
                    case opciones.GenerarCoordenas:


                        Timer er = new Timer();
                        er.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                        er.Interval = 3000;
                        er.Enabled = true;
                        break;
                    case opciones.PasarDatosPostgrest:
                        IMetodosPost Ejecutar = new MetodosPostgreSQL();
                        Ejecutar.InserarCoordenas();

                        break;
                    case opciones.Salir:
                        validar = false;
                        break;
                    default:
                        break;
                }
            }

        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            ASD.GenerarCoordenas();
        }
    }
}
