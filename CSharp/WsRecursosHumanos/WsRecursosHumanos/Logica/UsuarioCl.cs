using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WsRecursosHumanos.AccesoDatos;
using WsRecursosHumanos.Logica.SQL;

namespace WsRecursosHumanos.Logica
{
    public class UsuarioCL
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public SQL.IUsuarioSQL ObtenerInstancia()
        {
            IUsuarioSQL usuarioSql = null;

            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    break;
                case ContextDataBase.PostgreSql:
                    usuarioSql = new Postgres.UsuarioPostgres();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return usuarioSql;
        }


        public void InsertarEmpleado(string nombre, string clave)
        {
            IUsuarioSQL usuarioSql = this.ObtenerInstancia();
            usuarioSql.InsertarUsuario(nombre, clave);
            if (usuarioSql.IsError)
            {
                this.IsError = usuarioSql.IsError;
                this.ErrorDescripcion = usuarioSql.ErrorDescripcion;
            }
        }



        public void EditarEmpleado(int id, string nombre, string clave)
        {
            IUsuarioSQL usuarioSql = this.ObtenerInstancia();
            usuarioSql.EditarUsuario(id, nombre, clave);
            if (usuarioSql.IsError)
            {
                this.IsError = usuarioSql.IsError;
                this.ErrorDescripcion = usuarioSql.ErrorDescripcion;
            }
        }


        public void EliminarEmpleado(int id)
        {
            IUsuarioSQL usuarioSql = this.ObtenerInstancia();
            usuarioSql.EliminarUsuario(id);
            if (usuarioSql.IsError)
            {
                this.IsError = usuarioSql.IsError;
                this.ErrorDescripcion = usuarioSql.ErrorDescripcion;
            }
        }
        public void CambiarClave(int id, string clave)
        {
            IUsuarioSQL usuarioSql = this.ObtenerInstancia();
            usuarioSql.CambiarClaver(id, clave);
            if (usuarioSql.IsError)
            {
                this.IsError = usuarioSql.IsError;
                this.ErrorDescripcion = usuarioSql.ErrorDescripcion;
            }
        }
        public DataSet ObtenerUsuarios(string id)
        {
            IUsuarioSQL usuarioSql = this.ObtenerInstancia();
            DataSet datos = usuarioSql.ObtenerUsuarios(id);
            if (usuarioSql.IsError)
            {
                this.IsError = usuarioSql.IsError;
                this.ErrorDescripcion = usuarioSql.ErrorDescripcion;
            }
            return datos;
        }
        public DataSet TraerUsuarios(string filtro)
        {
            IUsuarioSQL usuarioSql = this.ObtenerInstancia();
            DataSet datos = usuarioSql.TraerUsuarios(filtro);
            if (usuarioSql.IsError)
            {
                this.IsError = usuarioSql.IsError;
                this.ErrorDescripcion = usuarioSql.ErrorDescripcion;
            }
            return datos;
        }
    }
}

        

    
    
