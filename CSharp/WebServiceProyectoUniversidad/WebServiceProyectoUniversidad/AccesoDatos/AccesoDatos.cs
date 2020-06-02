using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using UTNProyeto.AccesoDatos;

namespace UTNProyecto.AccesoDatos
{
    public class AccesoDatos
    {
        private static readonly Lazy<AccesoDatos> instance = new Lazy<AccesoDatos>(() => new AccesoDatos());
        public IAccesoDatos accesodatos;
        public AccesoDatos()
        {
            accesodatos= new AccesoDatosPostgreSql(
                         ConfigurationManager.AppSettings["ServerPG"],
                         ConfigurationManager.AppSettings["PuertoPG"],
                         ConfigurationManager.AppSettings["UsuarioPG"],
                         ConfigurationManager.AppSettings["PasswordPG"],
                         ConfigurationManager.AppSettings["DatabasePG"]
                         );
        }
        public static AccesoDatos Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}