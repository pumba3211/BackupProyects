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
    public class ClientePostgress : SQL.IClienteSQL
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

        public void InsertatCliente(int cedula, string nombre_completo, DateTime fecha_nacimiento, DateTime fecha_ingreso)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into cliente(cedula,nombre_completo,fecha_nacimiento,fecha_ingreso) values (@cedula,@nombre_completo,@fecha_nacimiento,@fecha_ingreso)");
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
                            ParameterName = "nombre_completo",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre_completo
                        },
                          new NpgsqlParameter
                            {
                            ParameterName = "fecha_nacimiento",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue = fecha_nacimiento
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "fecha_ingreso",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue =fecha_ingreso
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void ModificarCliente(int cedula, string nombre_completo, DateTime fecha_nacimiento, DateTime fecha_ingreso)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update cliente set nombre_completo=@nombre_completo,fecha_nacimiento=@fecha_nacimiento,fecha_ingreso=@fecha_ingreso where cedula=@cedula");
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
                            ParameterName = "nombre_completo",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = nombre_completo
                        },
                          new NpgsqlParameter
                            {
                            ParameterName = "fecha_nacimiento",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue =fecha_nacimiento
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "fecha_ingreso",
                            NpgsqlDbType = NpgsqlDbType.Date,
                            NpgsqlValue = fecha_ingreso
                        },
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarCliente(int Cedula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from cliente where cedula=@Cedula");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =  Cedula
                        },                       
                };
            AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            if (AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet CargarClientes(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from cliente ");
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

        public System.Data.DataSet ObtenerCliente(int cedula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("select * from cliente where cedula=@cedula");

            var parametros = new List<NpgsqlParameter>();

            parametros.Add(
                new NpgsqlParameter
                {
                    ParameterName = "cedula",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                    NpgsqlValue = cedula
                });

            var odatos = AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }

        public bool ClienteRepetido(int Cedula)
        {
            bool esta = false;
            DataSet datos = CargarClientes(null);

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                if (Cedula == Convert.ToInt32(datos.Tables[0].Rows[i]["cedula"].ToString()))
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
    }
}