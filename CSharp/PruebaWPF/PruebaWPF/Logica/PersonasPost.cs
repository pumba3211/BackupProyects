using Npgsql;
using NpgsqlTypes;
using PruebaWPF.Estructuras;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWPF.Logica
{
    public class PersonasPost:IPersonasSQL
    {

        public bool IsError
        {
            get
           ;
            set
            ;
        }

        public string ErrorDescripcion
        {
            get
           ;
            set
            ;
        }

        public void InsertarPersona(int cedula, string Nombre, string apellido)
        {
            var sql = new StringBuilder();
            sql.AppendLine("insert into persona (cedula,nombre,apellido) values (@cedula,@nombre,@apellido)");

            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = cedula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = Nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "apellido",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = apellido
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesodatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EditarPersona(int cedula, string Nombre, string apellido)
        {
            var sql = new StringBuilder();
            sql.AppendLine("update persona set nombre=@nombre,apellido=@apellido where cedula=@cedula");
            var parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "cedula",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = cedula
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = Nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "apellido",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = apellido
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesodatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public void EliminarPersona(int cedula)
        {
            var sql = new StringBuilder();
            sql.AppendLine("delete from persona where cedula=@cedula ");

            var parametros = new List<NpgsqlParameter>
                {                        
                    new NpgsqlParameter
                            {
                            ParameterName = "cedula",
                             NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue =cedula
                        },

                };
            AccesoDatos.AccesoDatos.Instance.accesodatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesodatos.IsError)
            {
                this.IsError = AccesoDatos.AccesoDatos.Instance.accesodatos.IsError;
                this.ErrorDescripcion = AccesoDatos.AccesoDatos.Instance.accesodatos.ErrorDescripcion;
            }
        }

        public System.Data.DataSet TraerPersonas(string filtro)
        {
            var sql = new StringBuilder();
            sql.AppendLine("Select * from persona");

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

            var odatos = AccesoDatos.AccesoDatos.Instance.accesodatos.EjecutarConsultaSQL(sql.ToString(), parametros);
            return odatos;
        }
        public List<Persona> CargarPersonas()
        {
            List<Persona> Personas = new List<Persona>();
            String Comando = "select * from persona";
            NpgsqlCommand Ejecutar = new NpgsqlCommand(Comando, AccesoDatos.AccesoDatos.Instance.accesodatos.ConexionPost);
            NpgsqlDataReader reader = Ejecutar.ExecuteReader();
            while (reader.Read())
            {
                Persona Persona = new Persona();
                Persona.cedula = Convert.ToInt32(reader["cedula"].ToString());
                Persona.nombre = reader["nombre"].ToString();
                Persona.apellido = reader["apellido"].ToString();
                Personas.Add(Persona);
            }
            reader.Close();
            return Personas;
                   
        }
    }
}
