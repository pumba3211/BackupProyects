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
    public class Grupo_EstudiantePostgress:SQL.IGrupo_Estudiante
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

        public void InsertarEstudianteGrupo(int id_grupo, int id_estudiante)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into grupo_estudiante(id_grupo,id_estudiante) values (@id_grupo,@id_estudiante)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id_grupo",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue=id_grupo                        
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_estudiante",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_estudiante
                        },                      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarEstudianteGrupo(int registro, int id_grupo, int id_estudiante)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update grupo_estudiante set id_grupo=@id_grupo,id_estudiante=@id_estudiante where registro=@registro");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id_grupo",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue=id_grupo                        
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_estudiante",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_estudiante
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "registro",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = registro
                        },   
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarRegistro(int registro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from grupo_estudiante where registro=@registro");
            var parametros = new List<NpgsqlParameter>
                {
        
                         new NpgsqlParameter
                            {
                            ParameterName = "registro",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = registro
                        },   
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarEstudiantesengrupo(int id_grupo)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.id_grupo,b.id_estudiante,c.cedula,c.nombre,c.apellidos from grupo_estudiante a,estudiante b,persona c ");
            sql.AppendLine("  where a.id_estudiante=b.id_estudiante and b.cedula=c.cedula and a.id_grupo=@id_grupo");
            var parametros = new List<NpgsqlParameter>();{
                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "id_grupo",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = id_grupo
                    });
            }

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        

        public bool ExisteRegistro(int n_registro)
        {
            bool esta = false;
            DataSet datos = CargarRegistros(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (n_registro == Convert.ToInt32(datos.Tables[0].Rows[i]["registro"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }


        public DataSet CargarRegistros(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from grupo_estudiante ");

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
        public bool EstudianteEnGrupo(int id_grupo, int id_estudiante)
        {
            bool esta=false;
            DataSet datos = CargarRegistros(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (id_grupo == Convert.ToInt32(datos.Tables[0].Rows[i]["id_grupo"].ToString()) &&
                    id_estudiante == Convert.ToInt32(datos.Tables[0].Rows[i]["id_estudiante"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
    }
}