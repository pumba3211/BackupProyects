using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using UTNProyecto.AccesoDatos;

namespace ExamenParqueo.Logica.Postgress
{
    public class VehiculoPostgress : SQL.IVehiculoSQL
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

        public void InsertatVehiculo(string matricula, int Cedula, string color, string marca)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into vehiculo(matricula,cedula,color,marca) values (@matricula,@Cedula,@color,@marca)");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "matricula",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  matricula
                        },
                      
                         new NpgsqlParameter
                            {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = Cedula
                        },
                          new NpgsqlParameter
                            {
                            ParameterName = "color",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  color
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "marca",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = marca
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarVehiculo(string matricula, int Cedula, string color, string marca)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update vehiculo set cedula=@Cedula,color=@color,marca=@marca where matricula=@matricula");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "matricula",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  matricula
                        },
                      
                         new NpgsqlParameter
                            {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = Cedula
                        },
                          new NpgsqlParameter
                            {
                            ParameterName = "color",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  color
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "marca",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = marca
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarVehiculo(string matricula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from vehiculo where matricula=@matricula");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "matricula",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue =  matricula
                        },                     
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarVehiculos(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from vehiculo ");
            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where cedula=@cedula");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "cedula",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                        NpgsqlValue = filtro
                    });
            }

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public System.Data.DataSet ObtenerVehicul(string matricula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from vehiculo where matricula=@matricula");

            var parametros = new List<NpgsqlParameter>();

            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "matricula",
                    NpgsqlDbType = NpgsqlDbType.Varchar,
                    NpgsqlValue = matricula
                });

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public bool VehiculoRepetido(string matricula)
        {
            bool esta = false;
            DataSet datos = CargarVehiculos(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (matricula == datos.Tables[0].Rows[i]["matricula"].ToString())
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
    }
}