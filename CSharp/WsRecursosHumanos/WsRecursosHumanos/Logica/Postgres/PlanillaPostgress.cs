using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WsRecursosHumanos.Logica.Postgres
{
    public class PlanillaPostgress:SQL.IPlanillaSQL
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

        public void InsertarPlanilla(string nombre, DateTime fecha)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into planilla (nombre,fecha) values (@nombre,@fecha)");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "fecha",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                            NpgsqlValue =fecha
                        }

                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public void EditarPlanilla(int id, string nombre, DateTime fecha)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update planilla set nombre=@nombre,fecha=@fecha where id=@id");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "fecha",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                            NpgsqlValue =fecha
                        },
                        new NpgsqlParameter
                        {
                            ParameterName = "id",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =id
                        }
                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet TraerPlanilla(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from planilla");
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

        public System.Data.DataSet ObtenerPlanilla(int ID)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from planilla");
            sql.AppendLine("where id=@ID");

            var parametros = new List<NpgsqlParameter>();

            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "id",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = ID
                });

            var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        public void InsertarPlanillaEmpleado(int idplanilla, int idempleado, double saldo)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into planillaempleado(planilla,empleado,saldo) values(@idplanilla,@idempleado.@saldo)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "planilla",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  idplanilla
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "empleado",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =idempleado
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "saldo",
                            NpgsqlDbType = NpgsqlDbType.Double,
                            NpgsqlValue=saldo
                        }
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