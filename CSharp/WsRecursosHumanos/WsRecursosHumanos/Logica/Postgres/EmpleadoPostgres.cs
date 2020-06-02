using System.Collections.Generic;
using System.Data;
using System.Text;
using NpgsqlTypes;
using WsRecursosHumanos.Logica.SQL;
using Npgsql;

namespace WsRecursosHumanos.Logica.Postgres
{
    public class EmpleadoPostgres : IEmpleadoSql
    {
        public bool IsError { get; set; }
        public string ErrorDescripcion { get; set; }

        public void InsertarEmpleado(int cedula, string nombre, int edad, string puesto)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into empleado (cedula,nombre,edad,puesto) values (@cedula,@nombre,@edad,@puesto)");

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
                            NpgsqlValue = nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "edad",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = edad
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "puesto",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = puesto
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void EditarEmpleado(int id, int cedula, string nombre, int edad, string puesto)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update empleado set cedula=@cedula,nombre=@nombre,edad=@edad,puesto=@puesto where id=@id ");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = cedula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "edad",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = edad
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "puesto",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = puesto
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

        public void EliminarEmpleado(int id)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from empleado where id=@id ");

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

        public DataSet TraerEmpleados(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from empleado ");

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

            var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
    }
}
