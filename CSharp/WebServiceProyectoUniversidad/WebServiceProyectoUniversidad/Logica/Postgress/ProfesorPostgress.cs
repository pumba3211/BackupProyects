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
    public class ProfesorPostgress:SQL.IProfesorSQL
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

        public void InsertarProfesor(int ID_Carrera, int Cedula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into profesor (id_carrera,cedula) values (@ID_Carrera,@Cedula)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  Cedula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_carrera",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = ID_Carrera
                        },
                                  
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarProfesor(int ID_Profesor, int ID_Carrera, int Cedula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update profesor set id_carrera=@ID_Carrera,cedula=@Cedula where id_profesor=@ID_Profesor");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  Cedula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_carrera",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = ID_Carrera
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_profesor",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = ID_Profesor
                        },
                                  
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarProfesor(int ID_Profesor)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from profesor where id_profesor=@ID_Profesor");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id_profesor",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  ID_Profesor
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarProfesor(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.cedula,a.nombre,a.apellidos,b.id_profesor,b.id_carrera from");
            sql.AppendLine("persona a, profesor b  where a.cedula=b.cedula");

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

        public bool ProfesorRepetido(int ID_Profesor)
        {
            bool esta = false;
            DataSet datos = CargarProfesor(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (ID_Profesor== Convert.ToInt32(datos.Tables[0].Rows[i]["id_profesor"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }

        public System.Data.DataSet ObtenerProfesor(int ID_Profesor)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.cedula,a.nombre,a.apellidos,b.id_profesor,b.id_carrera from");
            sql.AppendLine("persona a, profesor b  where a.cedula=b.cedula and id_profesor=@id_profesor");

            var parametros = new List<NpgsqlParameter>();
            parametros.Add(
               new NpgsqlParameter
               {
                   ParameterName = "id_profesor",
                   NpgsqlDbType = NpgsqlDbType.Integer,
                   NpgsqlValue = ID_Profesor
               });
            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
    }
}