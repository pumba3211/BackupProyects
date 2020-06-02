using ConsolaVehiculos.ConexionSQL;
using ConsolaVehiculos.Estructuras;
using ConsolaVehiculos.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.MetodosSql
{
    public class MetodosSQL : IMetodos
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


        public List<Vehiculo> TraerVehiculos()
        {
            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            DataTable VehiculosDatos = new DataTable();
            string select = "select * from vehiculo";
            SqlCommand sql = new SqlCommand(select, AccesarAconexion.Instance.AccesoSql.Conexion);
            SqlDataReader reader = sql.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Vehiculo Vehiculo = new Vehiculo();
                    Vehiculo.Matricula = reader["Matricula"].ToString();
                    Vehiculo.Marca = reader["Marca"].ToString();
                    Vehiculos.Add(Vehiculo);
                }
            }
            catch (Exception error)
            {
                this.IsError = AccesarAconexion.Instance.AccesoSql.IsError;
                this.ErrorDescripcion = AccesarAconexion.Instance.AccesoSql.ErrorDescripcion;
            }
            reader.Close();
            return Vehiculos;
        }
        public void GenerarCoordenas()
        {


            List<Vehiculo> Vehiculos = TraerVehiculos();
            IMetodosLatitudes LALO = new METODOS();
            for (int i = 0; i < Vehiculos.Count; i++)
            {
                LALO.generarCoordenas();
                string latitud = LALO.Latitud;
                string longitud = LALO.Longitud;
                string matricula = Vehiculos[i].Matricula;
                var sql = new StringBuilder();
                sql.AppendLine("insert into Coordenadas (Latitud,Longitud,matricula) values" + "('" + latitud + "','" + longitud + "','" + matricula + "')");

                var parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "latitud",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = latitud
                        },
                        new SqlParameter
                            {
                            ParameterName = "longitud",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = longitud
                        },
                        new SqlParameter
                            {
                            ParameterName = "Matricula",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = matricula                    
                        },
                    
                };
                LALO.Latitud = "";
                LALO.Longitud = "";
                AccesarAconexion.Instance.AccesoSql.EjecutarSQL(sql.ToString(), parametros);
                if (AccesarAconexion.Instance.AccesoSql.IsError)
                {
                    this.IsError = AccesarAconexion.Instance.AccesoSql.IsError;
                    this.ErrorDescripcion = AccesarAconexion.Instance.AccesoSql.ErrorDescripcion;
                }
            }
        }
        public List<Coordena> TraerCoordenas()
        {
            List<Coordena> Coordenas = new List<Coordena>();

            string select = "select * from coordenas";
            SqlCommand sql = new SqlCommand(select, AccesarAconexion.Instance.AccesoSql.Conexion);
            SqlDataReader reader = sql.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Coordena Coordena = new Coordena();
                    Coordena.Matricula = reader["Matricula"].ToString();
                    Coordena.Latitud = reader["Latitud"].ToString();
                    Coordena.Longitud = reader["Longitud"].ToString();
                    Coordenas.Add(Coordena);
                }
            }
            catch (Exception error)
            {
                this.IsError = AccesarAconexion.Instance.AccesoSql.IsError;
                this.ErrorDescripcion = AccesarAconexion.Instance.AccesoSql.ErrorDescripcion;
            }
            reader.Close();
            return Coordenas;
        }

    }
}



