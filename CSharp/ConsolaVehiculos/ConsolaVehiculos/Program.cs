using ConsolaVehiculos.ConexionSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesarAconexion Accesar = AccesarAconexion.Instance;

           
            
                Accesar.AccesosPostgreSqlt.Estado();
                Accesar.AccesoSqs.Estado();
            
            
            Console.ReadLine();
        }
    }
}
