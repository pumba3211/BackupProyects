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
    public class CarreraPostgress : SQL.ICarreraSQL
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

        public void InsertarCarrera(int id_carrera, string nombre_carrera, int estado)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into carrera(id_carrera,estado,nombre_carrera) values (@id_carrera,@estado,@nombre_carrera)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id_carrera",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  id_carrera
                        },
                      
                         new NpgsqlParameter
                            {
                            ParameterName = "estado",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = estado
                        },
                          new NpgsqlParameter
                            {
                            ParameterName = "nombre_carrera",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre_carrera
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarCarrera(int id_carrera, string nombre_carrera, int estado)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update carrera set estado=@estado,nombre_carrera=@nombre_carrera where id_carrera=@id_carrera");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id_carrera",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  id_carrera
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre_carrera",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre_carrera
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "estado",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = estado
                        },              
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarCarrera(int id_carrera)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from carrera where id_carrera=@id_carrera");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id_carrera",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  id_carrera
                        },
                       
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarCarreras(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from carrera ");
            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where nombre_carrera=@nombre_carrera");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "nombre_carrera",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public System.Data.DataSet ObtenerCarrera(int id_carrera)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from carrera where id_carrera=@id_carrera");

            var parametros = new List<NpgsqlParameter>();

            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "id_carrera",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_carrera
                });

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;

        }
        public bool CarrraRepetida(int id_carrera)
        {
            bool esta = false;
            DataSet datos = CargarCarreras(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (id_carrera == Convert.ToInt32(datos.Tables[0].Rows[i]["id_carrera"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;

        }
    }
}