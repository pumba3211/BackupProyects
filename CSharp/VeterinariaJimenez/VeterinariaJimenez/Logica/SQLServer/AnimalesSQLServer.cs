using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using VeterinariaJimenez.Logica.SQL;

namespace VeterinariaJimenez.Logica.SQLServer
{
    public class AnimalesSQLServer :IAnimalesSql

    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public void InsertarAnimal(string nombre, int especie, int tipo, string dueno)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into Animales (nombre,especie,tipo,dueno) values (@nombre,@especie,@tipo,@dueno)");

            var parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "nombre",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = nombre
                        },
                        new SqlParameter
                            {
                            ParameterName = "especie",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = especie
                        },
                        new SqlParameter
                            {
                            ParameterName = "tipo",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = tipo
                        },
                        new SqlParameter
                            {
                            ParameterName = "dueno",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = dueno
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

            var parametros = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where dueno=@dueno");

                parametros.Add(
                    new SqlParameter
                    {
                        ParameterName = "dueno",
                        SqlDbType = SqlDbType.VarChar,
                        SqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }


        public void EditarAnimal(int id, string nombre, int especie, int tipo, string dueno)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update animales set nombre=@nombre,especie=@especie,tipo=@tipo,dueno=@dueno where id=@id ");

            var parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "nombre",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = nombre
                        },
                        new SqlParameter
                            {
                            ParameterName = "especie",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = especie
                        },
                        new SqlParameter
                            {
                            ParameterName = "tipo",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = tipo
                        },
                        new SqlParameter
                            {
                            ParameterName = "dueno",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = dueno
                        },
                        new SqlParameter
                            {
                            ParameterName = "id",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = id
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion =AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }


        public void EliminarAnimal(int id)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from animales where id=@id ");

            var parametros = new List<SqlParameter>
                {                        
                    new SqlParameter
                            {
                            ParameterName = "id",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = id
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
