using System;
using System.Configuration;

namespace WsRecursosHumanos.AccesoDatos
{
    public class AccesoDatos
    {
        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static readonly Lazy<AccesoDatos> instance = new Lazy<AccesoDatos>(() => new AccesoDatos());
        public IAccesoDatos accesoDatos;

        // Constructor privado para evitar la instanciación directa
        private AccesoDatos()
        {
            ContextDataBase contextDataBase;

            Enum.TryParse(ConfigurationManager.AppSettings["ContextDataBase"], out contextDataBase);


            switch (contextDataBase)
            {
                case ContextDataBase.PostgreSql:
                    accesoDatos = new AccesoDatosPostgreSql(
                        ConfigurationManager.AppSettings["ServerPG"],
                        ConfigurationManager.AppSettings["PuertoPG"],
                        ConfigurationManager.AppSettings["UsuarioPG"],
                        ConfigurationManager.AppSettings["PasswordPG"],
                        ConfigurationManager.AppSettings["DatabasePG"]
                        );
                    break;

                case ContextDataBase.SqlServer:
                    accesoDatos = new AccesoDatosSqlServer(
                        ConfigurationManager.AppSettings["Server"],
                        ConfigurationManager.AppSettings["Usuario"],
                        ConfigurationManager.AppSettings["Password"],
                        ConfigurationManager.AppSettings["Database"]
                        );
                    break;
            }
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