using System;
using System.Configuration;

namespace ProyectoGPS.AccesoDatos
{
    public class AccesoDatos
    {
        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static readonly Lazy<AccesoDatos> instance = new Lazy<AccesoDatos>(() => new AccesoDatos());
        public IAccesoDatos accesoDatos;
        public IAccesoDatos accesoPostgreSQL;

        // Constructor privado para evitar la instanciación directa
        private AccesoDatos()
        {
            ContextDataBase contextDataBase;

            Enum.TryParse(ConfigurationManager.AppSettings["ContextDataBase"], out contextDataBase);


         
                    accesoPostgreSQL = new AccesoDatosPostgreSql(
                        ConfigurationManager.AppSettings["ServerPG"],
                        ConfigurationManager.AppSettings["PuertoPG"],
                        ConfigurationManager.AppSettings["UsuarioPG"],
                        ConfigurationManager.AppSettings["PasswordPG"],
                        ConfigurationManager.AppSettings["DatabasePG"]);
                   
                    accesoDatos = new AccesoDatosSqlServer(
                        ConfigurationManager.AppSettings["Server"],
                        ConfigurationManager.AppSettings["Usuario"],
                        ConfigurationManager.AppSettings["Password"],
                        ConfigurationManager.AppSettings["Database"]);
            
        }

        // Propiedad para acceder a la instancia
        public static AccesoDatos Instance
        {
            get
            {
                return instance.Value;
            }
        }

    }
}