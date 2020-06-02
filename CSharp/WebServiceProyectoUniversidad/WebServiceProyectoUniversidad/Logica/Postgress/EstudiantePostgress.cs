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
    public class EstudiantePostgress :SQL.IEstudianteSQL
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

        public void InsertarEstudiante(DateTime fecha_nacimiento, int id_carrera, int cedula, string direccion)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into estudiante (fecha_nacimiento,id_carrera,cedula,direccion) values (@fecha_nacimiento,@id_carrera,@cedula,@direccion)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "fecha_nacimiento",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue =  fecha_nacimiento
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_carrera",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_carrera
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = cedula
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "direccion",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = direccion
                        },
                      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarEstudiante(int id_estudiante, DateTime fecha_nacimiento, int id_carrera, int cedula, string direccion)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update estudiante set fecha_nacimiento=@fecha_nacimiento,id_carrera=@id_carrera,cedula=@cedula,direccion=@direccion where id_estudiante=@id_estudiante");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "fecha_nacimiento",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue =  fecha_nacimiento
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_carrera",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_carrera
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = cedula
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "direccion",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = direccion
                        },
                        new NpgsqlParameter{
                            ParameterName="id_estudiante",
                            NpgsqlDbType=NpgsqlDbType.Integer,
                            NpgsqlValue=id_estudiante
                        },
                      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarEstudiante(int id_estudiante)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from estudiante where id_estudiante=@id_estudiante");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                    {
                        ParameterName="id_estudiante",
                        NpgsqlDbType=NpgsqlDbType.Integer,
                        NpgsqlValue=id_estudiante
                    }
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarEstudiantes(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.cedula,a.nombre,a.apellidos,b.fecha_nacimiento,b.id_estudiante,b.id_carrera,b.direccion from");
            sql.AppendLine("persona a,estudiante b where a.cedula=b.cedula");

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

        public System.Data.DataSet ObtenerEstudiante(int id_estudiante)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.cedula,a.nombre,a.apellidos,b.fecha_nacimiento,b.id_estudiante,b.id_carrera,b.direccion from");
            sql.AppendLine("persona a,estudiante b where a.cedula=b.cedula and id_estudiante=@id_estudiante");

            var parametros = new List<NpgsqlParameter>();
                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id_estudiante",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = id_estudiante
                    });
            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public bool EstudianteRepetido(int id_estudiante)
        {
            bool esta = false;
            DataSet datos = CargarEstudiantes(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if(id_estudiante == Convert.ToInt32(datos.Tables[0].Rows[i]["id_estudiante"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
    }
}