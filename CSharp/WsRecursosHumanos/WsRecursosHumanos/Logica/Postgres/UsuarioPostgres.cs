using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace WsRecursosHumanos.Logica.Postgres
{
    public class UsuarioPostgres : SQL.IUsuarioSQL
    {
        public bool IsError
        {
            get;
            set;
        }

        public string ErrorDescripcion
        {
            get;
            set;
        }

        public void InsertarUsuario(string nombre, string clave)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into usuario (nombre,clave) values (@nombre,@clave)");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "clave",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = clave
                        },                     

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void EditarUsuario(int id, string nombre, string clave)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update usuario set nombre=@nombre,clave=@clave where id=@id");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "clave",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = clave
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id
                        },
                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void EliminarUsuario(int id)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from usuario where id=@id ");

            var parametros = new List<NpgsqlParameter>
                {                        
                    new NpgsqlParameter
                            {
                            ParameterName = "id",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void CambiarClaver(int id, string clave)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update usuario clave=@clave where id=@id");

            var parametros = new List<NpgsqlParameter>
                {
                        new NpgsqlParameter
                            {
                            ParameterName = "clave",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = clave
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id
                        },
                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet ObtenerUsuarios(string id)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet TraerUsuarios(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from usuario ");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where nombre=@nombre");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "nombre",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        public DataSet ValidarSession(string nombre, string clave)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from usuario ");
            sql.AppendLine("where nombre=@nombre and clave=@clave");
             var parametros = new List<NpgsqlParameter>
                {
                        new NpgsqlParameter
                            {
                            ParameterName = "clave",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = clave
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =nombre
                        },
                };
             var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
             return odatos;
        }
    }
}