using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRonald.ConexionSQL
{
    class AccesoADatos
    {
        private static readonly Lazy<AccesoADatos> instance = new Lazy<AccesoADatos>(() => new AccesoADatos());
        public IMetodosDeConexion MetodosConexion;

        // Constructor privado para evitar la instanciación directa
        private AccesoADatos()
        {
            MetodosConexion = new ConexionSQL(
                        ConfigurationManager.AppSettings["Server"],
                        ConfigurationManager.AppSettings["Usuario"],
                        ConfigurationManager.AppSettings["Password"],
                        ConfigurationManager.AppSettings["Database"]
                        );
        }


        // Propiedad para acceder a la instancia
        public static AccesoADatos Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}