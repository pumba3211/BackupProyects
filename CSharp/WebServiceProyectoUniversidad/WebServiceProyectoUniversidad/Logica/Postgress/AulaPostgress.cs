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
    public class AulaPostgress:SQL.IAulaSQL
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

        public void InsertarAula(string nombre_aula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into aula(nombre_aula) values (@nombre_aula)");
            var parametros = new List<NpgsqlParameter>
                {                   
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre_aula",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre_aula
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarAula(int ID_Aula, string nombre_aula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update aula set nombre_aula=@nombre_aula where id_aula=@id_aula");
            var parametros = new List<NpgsqlParameter>
                {                   
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre_aula",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre_aula
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "id_aula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = ID_Aula
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarAula(int ID_Aula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from aula where id_aula=@id_aula");
            var parametros = new List<NpgsqlParameter>
                {                   
                        new NpgsqlParameter
                            {
                            ParameterName = "id_aula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = ID_Aula
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarAula(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from aula");
            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where nombre_aula=@nombre_aula");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "nombre_aula",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public System.Data.DataSet ObtenerAula(int ID_Aula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from aula where id_aula=@id_aula");
            var parametros = new List<NpgsqlParameter>();
            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "id_aula",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = ID_Aula
                });

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        public bool AulaRepetida(int ID_Aula)
        {
            bool esta = false;
            DataSet datos = CargarAula(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (ID_Aula == Convert.ToInt32(datos.Tables[0].Rows[i]["id_aula"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
    }
}