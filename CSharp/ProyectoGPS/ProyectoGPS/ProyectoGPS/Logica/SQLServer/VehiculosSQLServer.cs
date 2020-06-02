using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ProyectoGPS.Logica.SQL;

namespace ProyectoGPS.Logica.SQLServer
{
    public class VehiculosSQLServer :IVehiculosSql

    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public void InsertarVehiculo(string matricula, string marca)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into Vehiculo (matricula,marca) values (@matricula,@marca)");

            var parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "matricula",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = matricula
                        },
                        new SqlParameter
                            {
                            ParameterName = "marca",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = marca
                        },
                       
                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }

        public DataSet TraerVehiculos(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from vehiculo ");

            var parametros = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where matricula=@matricula");

                parametros.Add(
                    new SqlParameter
                    {
                        ParameterName = "matricula",
                        SqlDbType = SqlDbType.VarChar,
                        SqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }


        public void EditarVehiculo(string matricula, string marca, string auxiliar)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update vehiculo set matricula=@matricula,marca=@marca where matricula='"+auxiliar+"'");

            var parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "matricula",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = matricula
                        },
                        new SqlParameter
                            {
                            ParameterName = "marca",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = marca
                        },
                        
                };
            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesoDatos.IsError;
                this.ErrorDescripcion =AccesoDatos.AccesoDatos.Instance.accesoDatos.ErrorDescripcion;
            }
        }


        public void EliminarVehiculo(string matricula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from vehiculo where matricula=@matricula ");

            var parametros = new List<SqlParameter>
                {                        
                    new SqlParameter
                            {
                            ParameterName = "matricula",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = matricula
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
