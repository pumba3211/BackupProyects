using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using UTNProyecto.AccesoDatos;

namespace WebServiceProyectoUniversidad.Logica.Postgress
{
    public class AdministrativoPostgress:SQL.IAdministrativoSQL
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

        public void InsertarAdministrativo(string username, string password,int cedula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into administrativo (username,password,cedula) values (@username,@password,@cedula)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "username",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  username
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "password",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = password
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = cedula
                        },
                      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void CambiarClave(string username, string password)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update administrativo set password=@password where username=@username");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "username",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  username
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "password",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = password
                        },
                      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }
        public void CambiarPropietario(string username, int cedula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update administrativo set cedula=@cedula where username=@username");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "username",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  username
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = cedula
                        },
                      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }
        public void EliminarAdministrador(string username)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from administrativo where username=@username");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "username",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  username
                        },                     
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarAdministrativos(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.cedula,a.nombre,a.apellidos,b.username from");
            sql.AppendLine("persona a, administrativo b  where a.cedula=b.cedula");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where username=@username");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "username",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        public System.Data.DataSet ObtenerAdministrador(string username)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.cedula,a.nombre,a.apellidos,b.username from ");
            sql.AppendLine("persona a, administrativo b  where a.cedula=b.cedula and username=@username");

            var parametros = new List<NpgsqlParameter>();

            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "username",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = username
                });

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public System.Data.DataSet ValidarSession(string username, string password)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from administrativo");
            sql.AppendLine("where username=@username and password=@password");

            var parametros = new List<NpgsqlParameter>
                {
                        new NpgsqlParameter
                            {
                            ParameterName = "username",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = username
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "password",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = password
                        },

                };
            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        public bool UsernameRepetido(string username)
        {
            bool esta = false;
            DataSet datos = CargarAdministrativos(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (username == datos.Tables[0].Rows[i]["username"].ToString())
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
    }
}