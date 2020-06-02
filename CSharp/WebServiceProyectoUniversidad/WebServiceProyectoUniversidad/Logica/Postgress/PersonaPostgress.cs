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
    public class PersonaPostgress:SQL.IPersonasSQL
    {
        public bool IsError
        {
            set;
            get;
        }

        public string ErrorDescripcion
        {
            set;
            get;
        }
        #region InsertarPersona
        public void InsertarPersona(int cedula, string Nombre, string Apellidos)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into persona (cedula,nombre,apellidos) values (@cedula,@nombre,@apellidos)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  cedula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = Nombre
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "apellidos",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = Apellidos
                        },              
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }
        #endregion 

        public void ModificarPersona(int cedula, string Nombre, string Apellidos)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update persona set nombre=@Nombre,Apellidos=@Apellidos where cedula=@cedula");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  cedula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "Nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = Nombre
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "Apellidos",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = Apellidos
                        },              
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarPersona(int cedula)
        {
             var sql = new StringBuilder();
            sql.AppendLine("delete from persona where cedula=@cedula");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  cedula
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarPersonas(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from persona ");

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

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        public bool CedulaRepetida(int cedula)
        {
            bool esta = false;
            DataSet datos= CargarPersonas(null);
            
             for(int i=0;i<datos.Tables[0].Rows.Count;i++)
             {
                 if (cedula == Convert.ToInt32(datos.Tables[0].Rows[i]["cedula"].ToString()))
                 {
                     esta = true;
                     break;
                 }
             }
             return esta;
        }
    }
}