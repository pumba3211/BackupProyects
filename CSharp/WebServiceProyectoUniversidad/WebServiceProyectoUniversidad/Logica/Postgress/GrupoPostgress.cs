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
    public class GrupoPostgress:SQL.IGrupoSQL
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

        public void InsertarGrupo(int id_carrera, int id_profesor, int id_aula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into grupo(id_carrera,id_profesor,id_aula) values (@id_carrera,@id_profesor,@id_aula)");
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
                            ParameterName = "id_profesor",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_profesor
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "id_aula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_aula
                        },              
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarGrupo(int id_grupo, int id_carrera, int id_profesor, int id_aula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update  grupo set id_carrera=@id_carrera,id_grupo=@id_grupo,id_aula=@id_aula where id_grupo=@id_grupo");
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
                            ParameterName = "id_profesor",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_profesor
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "id_aula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_aula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "id_grupo",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_grupo
                        },      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarGrupo(int id_grupo)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from grupo where id_grupo=@id_grupo");
            var parametros = new List<NpgsqlParameter>
                {
                        new NpgsqlParameter
                            {
                            ParameterName = "id_grupo",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id_grupo
                        },      
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarGrupos(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.id_grupo,b.id_carrera,b.nombre_carrera,c.id_profesor,e.nombre,d.id_aula,d.nombre_aula from");
            sql.AppendLine("grupo a,carrera b,profesor c,aula d,persona e ");
            sql.AppendLine("where a.id_carrera=b.id_carrera and a.id_profesor=c.id_profesor and d.id_aula=d.id_aula and c.cedula=e.cedula");

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

        public System.Data.DataSet ObtenerGrupo(int id_grupo)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select a.id_grupo,b.id_carrera,b.nombre_carrera,c.id_profesor,e.nombre,d.id_aula,d.nombre_aula from");
            sql.AppendLine("grupo a,carrera b,profesor c,aula d,persona e ");
            sql.AppendLine("where a.id_carrera=b.id_carrera and a.id_profesor=c.id_profesor and d.id_aula=d.id_aula and c.cedula=e.cedula and id_grupo=@id_grupo");

            var parametros = new List<NpgsqlParameter>();
            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "id_grupo",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = id_grupo
                });
            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public bool GrupoRepetido(int id_grupo)
        {
              bool esta = false;
            DataSet datos= CargarGrupos(null);
            
             for(int i=0;i<datos.Tables[0].Rows.Count;i++)
             {
                 if (id_grupo == Convert.ToInt32(datos.Tables[0].Rows[i]["id_grupo"].ToString()))
                 {
                     esta = true;
                     break;
                 }
             }
             return esta;
        }
    }
}