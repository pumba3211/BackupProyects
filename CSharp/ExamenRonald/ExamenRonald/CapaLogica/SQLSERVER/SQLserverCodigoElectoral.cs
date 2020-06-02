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
    public class SQLserverCodigoElectoral : ICodigoElectoralSQL
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public void InsertarCodigo(String Codele, String Provincia, String Canton, String Distrito)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into CodigoElectoral (Codele,Provincia,Canton,Distrito) values (@Codele,@Provincia,@Canton,@Distrito)");

            var parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "Codele",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = Codele.ToString().Trim()
                        },
                        new SqlParameter
                            {
                            ParameterName = "Provincia",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = Provincia.ToString().Trim()
                        },
                        new SqlParameter
                            {
                            ParameterName = "Canton",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = Canton.ToString().Trim()
                        },
                        new SqlParameter
                            {
                            ParameterName = "Distrito",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = Distrito.ToString().Trim()
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
