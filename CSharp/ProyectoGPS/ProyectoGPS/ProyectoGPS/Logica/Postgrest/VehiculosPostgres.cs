using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGPS.Logica.SQL;

namespace ProyectoGPS.Logica.Postgrest
{
    public class VehiculosPostgres : IVehiculosSql
    {
        public bool IsError { set; get; }

        public string ErrorDescripcion { set; get; }

        public void InsertarVehiculo(string matricula, string marca)
        {
            string consulta = "";
           
            consulta = "insert into vehiculo (matricula,marca) values ('" + matricula + "','" + marca + "')";
            NpgsqlCommand ejecutarinsert = new NpgsqlCommand(consulta, AccesoDatos.AccesoDatos.Instance.accesoPostgreSQL.ConexionPG);
                ejecutarinsert.ExecuteNonQuery();
        }

        public DataSet TraerVehiculos(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from vehiculo ");

            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where matricula=@matricula");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "matricula",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }


        public void EditarVehiculo(string matricula, string marca, string auxiliar)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update vehiculo set matricula=@matricula,marca=@marca where matricula=@auxiliar");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "matricula",
                             NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = matricula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "marca",
                             NpgsqlDbType = NpgsqlDbType.Varchar,
                             NpgsqlValue = marca
                        },
                        
                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }


        public void EliminarVehiculo(string matricula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from vehiculo where matricula=@matricula ");

            var parametros = new List<NpgsqlParameter>
                {                        
                    new NpgsqlParameter
                            {
                            ParameterName = "matricula",
                             NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = matricula
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
