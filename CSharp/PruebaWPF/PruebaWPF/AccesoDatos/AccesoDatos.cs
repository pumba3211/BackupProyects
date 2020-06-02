using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using PruebaWPF.AccesoDatos;

namespace PruebaWPF.AccesoDatos
{
    public class AccesoDatos
    {
        private static readonly Lazy<AccesoDatos> instance = new Lazy<AccesoDatos>(() => new AccesoDatos());
        public IAccesoDatos accesodatos;
        public AccesoDatos()
        {
            accesodatos= new AccesoDatosPostgreSql(
                         ConfigurationManager.AppSettings["Server"],
                         ConfigurationManager.AppSettings["Puerto"],
                         ConfigurationManager.AppSettings["Usuario"],
                         ConfigurationManager.AppSettings["Password"],
                         ConfigurationManager.AppSettings["Database"]
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