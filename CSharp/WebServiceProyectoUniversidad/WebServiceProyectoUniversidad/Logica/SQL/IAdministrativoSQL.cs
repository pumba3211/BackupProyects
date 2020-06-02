using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface IAdministrativoSQL
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarAdministrativo(string username, string password,int cedula);
        void CambiarClave(string username, string password);
        void CambiarPropietario(string username, int cedula);
        void EliminarAdministrador(string username);
        DataSet CargarAdministrativos(string filtro);
        DataSet ObtenerAdministrador(string username);
        DataSet ValidarSession(string username, string password); 
        Boolean UsernameRepetido(string username);

        #endregion
    }
}
