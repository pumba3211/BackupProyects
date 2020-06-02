using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaJimenez.Logica.SQL;

namespace VeterinariaJimenez.Logica.Postgrest
{
    class AnimalesPostgres : IAnimalesSql
    {
        public bool IsError { set; get; }

        public string ErrorDescripcion { set; get; }

        public void InsertarAnimal(string nombre, int especie, int tipo, string dueno)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into animales (nombre,especie,tipo,dueno) values (@nombre,@especie,@tipo,@dueno)");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "especie",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = especie
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "tipo",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = tipo
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "dueno",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = dueno
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public DataSet TraerAnimales(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from animales ");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where dueno=@dueno");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "dueno",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }


        public void EditarAnimal(int id, string nombre, int especie, int tipo, string dueno)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update animales set nombre=@nombre,especie=@especie,tipo=@tipo,dueno=@dueno where id=@id ");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                             NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "especie",
                             NpgsqlDbType = NpgsqlDbType.Integer,
                             NpgsqlValue = especie
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "tipo",
                             NpgsqlDbType = NpgsqlDbType.Integer,
                             NpgsqlValue = tipo
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "dueno",
                             NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue= dueno
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


        public void EliminarAnimal(int id)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from animales where id=@id ");

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
    }
}
