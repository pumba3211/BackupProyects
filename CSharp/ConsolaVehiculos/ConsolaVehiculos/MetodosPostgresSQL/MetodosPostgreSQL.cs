using ConsolaVehiculos.ConexionSQL;
using ConsolaVehiculos.Estructuras;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos.MetodosPostgresSQL
{
    class MetodosPostgreSQL : IMetodosPost
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

        public void InserarCoordenas()
        {


            string BORRAR = "delete from coordenas";
            NpgsqlCommand ejecutar = new NpgsqlCommand(BORRAR, AccesarAconexion.Instance.AccesosPostgreSqlt.ConexionPost);
            ejecutar.ExecuteNonQuery();
            List<Coordena> Coordenas = TraerCoordenas();
            for (int i = 0; i < Coordenas.Count; i++)
            {

                string latitud = Coordenas[i].Latitud;
                string longitud = Coordenas[i].Longitud;
                string matricula = Coordenas[i].Matricula;
                string consulta = "";
                consulta = "insert into coordenas (latitud,longitud,matricula) values ('" + latitud + "','" + longitud + "','" + matricula + "')";
                NpgsqlCommand ejecutarinsert = new NpgsqlCommand(consulta, AccesarAconexion.Instance.AccesosPostgreSqlt.ConexionPost);
                ejecutarinsert.ExecuteNonQuery();
            }
        }


        public List<Coordena> TraerCoordenas()
        {
            List<Coordena> Coordenas = new List<Coordena>();

            string select = "select * from coordenadas";
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
