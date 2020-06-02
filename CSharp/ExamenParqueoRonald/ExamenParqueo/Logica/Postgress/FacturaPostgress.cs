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
    public class FacturaPostgress : SQL.IFacturaSQL
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

        public void InsertarFactura(string matricula, DateTime fecha_ingreso, DateTime fecha_salida, double costo_hora)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into factura(matricula,fecha_ingreso,fecha_salida,costo_hora) values (@matricula,@fecha_ingreso,@fecha_salida,@costo_hora)");
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
                            ParameterName = "fecha_ingreso",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                            NpgsqlValue = fecha_ingreso
                            },
                          new NpgsqlParameter
                            {
                            ParameterName = "fecha_salida",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                            NpgsqlValue =fecha_salida

                            },
                         new NpgsqlParameter
                            {
                            ParameterName = "costo_hora",
                            NpgsqlDbType = NpgsqlDbType.Double,
                            NpgsqlValue = costo_hora
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarFactura(string matricula, DateTime Fecha_Ingreso, DateTime Fecha_Salida, double costo_hora, int N_Factura)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update factura set matricula=@matricula,fecha_ingreso=@fecha_Ingreso,fecha_salida=@Fecha_Salida,costo_hora=@Costo_Hora where n_factura=@N_factura");
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
                            ParameterName = "fecha_ingreso",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                            NpgsqlValue = Fecha_Ingreso
                            },
                          new NpgsqlParameter
                            {
                            ParameterName = "fecha_salida",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                            NpgsqlValue = Fecha_Salida
                            },
                         new NpgsqlParameter
                            {
                            ParameterName = "costo_hora",
                            NpgsqlDbType = NpgsqlDbType.Double,
                            NpgsqlValue = costo_hora
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "n_factura",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = N_Factura
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarFactura(int N_Factura)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from factura where n_factura=@N_Factura");
            var parametros = new List<NpgsqlParameter>
                {                  
                        new NpgsqlParameter
                            {
                            ParameterName = "n_factura",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = N_Factura
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarFacturas(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from factura ");
            var parametros = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(filtro))
            {
                sql.AppendLine("where matricula=@matricula");

                parametros.Add(
                    new NpgsqlParameter
                    {
                        ParameterName = "matricula",
                        NpgsqlDbType = NpgsqlDbType.Varchar,
                        NpgsqlValue = filtro,
                    });
            }

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public System.Data.DataSet ObtenerFactura(int N_Factura)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from factura where n_factura=@N_Factura");

            var parametros = new List<NpgsqlParameter>();

            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "n_factura",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = N_Factura
                });

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public bool FacturaExiste(int N_Factura)
        {
            bool esta = false;
            DataSet datos = CargarFacturas(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (N_Factura == Convert.ToInt32(datos.Tables[0].Rows[i]["n_factura"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
        public double CalculaCosto(int N_Factura)
        {
            double Total = 0;
            Estructuras.Factura Factura = new Estructuras.Factura();
            var data = ObtenerFactura(N_Factura);
            Factura.Fecha_ingreso = Convert.ToDateTime(data.Tables[0].Rows[0]["fecha_ingreso"]);
            Factura.Fecha_salida = Convert.ToDateTime(data.Tables[0].Rows[0]["fecha_salida"]);
            Factura.Costo_Hora = Convert.ToDouble(data.Tables[0].Rows[0]["costo_hora"]);
            TimeSpan horas = Factura.Fecha_ingreso - Factura.Fecha_salida;

            Total = Factura.Costo_Hora * horas.TotalHours;
            return Total;
        }
    }
}