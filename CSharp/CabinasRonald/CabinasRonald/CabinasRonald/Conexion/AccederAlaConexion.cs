using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinasRonald.Conexion
{
    public class AccederAlaConexion
    {
        private static readonly Lazy<AccederAlaConexion> instance = new Lazy<AccederAlaConexion>(() => new AccederAlaConexion());
        public IMetodosConexion Accesar;
        private AccederAlaConexion()
        {
            Accesar = new ConexionSQL(
                     ConfigurationManager.AppSettings["Server"],
                     ConfigurationManager.AppSettings["Usuario"],
                     ConfigurationManager.AppSettings["Password"],
                     ConfigurationManager.AppSettings["Database"]
                     );
        }


        public static AccederAlaConexion Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
    