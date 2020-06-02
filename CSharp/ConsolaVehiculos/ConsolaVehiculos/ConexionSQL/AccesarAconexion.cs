using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.ConexionSQL
{
    public class AccesarAconexion
    {
         // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static readonly Lazy<AccesarAconexion> instance = new Lazy<AccesarAconexion>(() => new AccesarAconexion());
        public IMetodosConexion AccesoSqs;
        public IMetodosConexion AccesosPostgreSqlt;
        public ContextDataBase contextDataBase;
        // Constructor privado para evitar la instanciación directa
        public AccesarAconexion()
        {
             
            Enum.TryParse(ConfigurationManager.AppSettings["ContextDataBase"], out contextDataBase);


          
              

                    AccesosPostgreSqlt = new AccesosPostgreSql(
                            ConfigurationManager.AppSettings["ServerPG"],
                            ConfigurationManager.AppSettings["PuertoPG"],
                            ConfigurationManager.AppSettings["UsuarioPG"],
                            ConfigurationManager.AppSettings["PasswordPG"],
                            ConfigurationManager.AppSettings["DatabasePG"]
                            );
                 

               

                    AccesoSqs = new AccesoSql(
                           ConfigurationManager.AppSettings["ServerSQL"],
                           ConfigurationManager.AppSettings["Usuario"],
                           ConfigurationManager.AppSettings["Password"],
                           ConfigurationManager.AppSettings["Database"]
                          );
                    
            
        }

        // Propiedad para acceder a la instancia
        public static AccesarAconexion Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
    
}
