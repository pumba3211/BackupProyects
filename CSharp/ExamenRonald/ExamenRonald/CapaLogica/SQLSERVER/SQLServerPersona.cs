using ExamenRonald.CapaLogica.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRonald.CapaLogica.SQLSERVER
{
    public class SQLServerPersona : IPersonasSQL
    {
        public bool IsError { set; get; }


        public string ErrorDescripcion { set; get; }


        public void InsertarPersona(String Cedula, String NombreCompleto, int Sexo, String Codelec)
        {
            {
                var sql = new StringBuilder();
                sql.AppendLine("insert into Persona (Cedula,NombreCompleto,Sexo,Codelec) values (@Cedula,@NombreCompleto,@Sexo,@Codelec)");

                var parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "Cedula",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = Cedula.ToString().Trim()
                        },
                        new SqlParameter
                            {
                            ParameterName = "NombreComleto",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = NombreCompleto.ToString().Trim()
                        },
                        new SqlParameter
                            {
                            ParameterName = "Sexo",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = Sexo
                        },
                        new SqlParameter
                            {
                            ParameterName = "Codelec",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = Codelec.ToString().Trim()
                        },

                };
                ConexionSQL.AccesoADatos.Instance.MetodosConexion.EjecutarConsultaSQL(sql.ToString(), parametros);
                if (ConexionSQL.AccesoADatos.Instance.MetodosConexion.IsError)
                {
                    this.IsError = true;
                    this.ErrorDescripcion = ConexionSQL.AccesoADatos.Instance.MetodosConexion.ErrorDescripcion;
                }
            }
        }
    }
}