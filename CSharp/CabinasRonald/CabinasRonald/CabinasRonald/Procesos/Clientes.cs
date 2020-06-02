using CabinasRonald.Estructuras;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinasRonald.Procesos
{
    public class Clientes
    {
        bool error { set; get; }
        string DescripcionError { set; get; }

        public void InsertarCliente(String Cedula, String Nombre, String Apellidos, String Empresa, int tipo)
        {
            String Comando = "insert into Clientes (CedulaCliente,Nombre,Apellidos,Empresa,Freecuente) values('" +
                "'" + Cedula + "','" + Nombre + "','" + Apellidos + "','" + Empresa + "','" + 0 + "')";
            SqlCommand Ejecutar = new SqlCommand(Comando, Conexion.AccederAlaConexion.Instance.Accesar.Conexion);
            try
            {
                Ejecutar.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarCliente(String Cedula)
        {
            String Comando = "delete from Clientes where CedulaCliente='" + Cedula + "'";
            SqlCommand Ejecutar = new SqlCommand(Comando, Conexion.AccederAlaConexion.Instance.Accesar.Conexion);
            try
            {
                Ejecutar.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarCliente(String Cedula, String Nombre, String Apellidos, String Empresa, int tipo)
        {
            String Comando = "update Cliente set Nombre='" + Nombre + "',Apellidos='" + Apellidos + "',Empresa='" + Empresa + "',Freecuente='" + tipo +
                "' where CedulaCliente='" + Cedula + "'";
            SqlCommand Ejecutar = new SqlCommand(Comando, Conexion.AccederAlaConexion.Instance.Accesar.Conexion);
            try
            {
                Ejecutar.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> Clientes = new List<Cliente>();
            String Comando = "select * from Clientes";
            SqlCommand Ejecutar = new SqlCommand(Comando, Conexion.AccederAlaConexion.Instance.Accesar.Conexion);
            SqlDataReader reader =Ejecutar.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    Cliente Cliente = new Cliente();
                    Cliente.CedulaCliente = reader["CedulaCliente"].ToString();
                    Cliente.Nombre = reader["Nombre"].ToString();
                    Cliente.Apellidos = reader["Apellido"].ToString();
                    Cliente.Empresa = reader["Empresa"].ToString();
                    Cliente.Freecuente = Convert.ToInt32(reader["Frecuente"].ToString());
                    Clientes.Add(Cliente);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }           
            return Clientes;
        }
    }
}
