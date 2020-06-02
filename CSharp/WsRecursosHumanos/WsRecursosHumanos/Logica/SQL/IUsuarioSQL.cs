using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsRecursosHumanos.Logica.SQL
{
    public interface IUsuarioSQL
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarUsuario(string nombre,string clave);
        void EditarUsuario(int id, string nombre, string clave);
        void EliminarUsuario(int id);
        void CambiarClaver(int id, string clave);
        DataSet ObtenerUsuarios(string id);
        DataSet TraerUsuarios(string filtro);
        DataSet ValidarSession(int id, string clave);
        #endregion
    }
}
