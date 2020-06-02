using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinasRonald.Conexion
{
    public class ConexionSQL:IMetodosConexion
    {
        public ConexionSQL(String servidor, String usuario, String contrasena, String baseDatos)
        {
            this.LimpiarEstado();
            Conexion = new SqlConnection("Data Source=" + servidor + ";UID=" + usuario + ";PWD=" + contrasena + ";Initial Catalog=" + baseDatos);

            Instancias += 1;
            // no puede haber + de una instancia de la clase
            if (Instancias > 1)
                return;
            try
            {
                Conexion.Open();
            }
            catch (Exception error)
            {
                HayError = true;
                ErrorDescripcion = "Error de Conexión \n";
                ErrorDescripcion += error.Message;
                Instancias = 0;
            }
        }

        // destructor
        ~ConexionSQL()
        {
            try
            {
                Conexion.Close();
            }
            catch (Exception error)
            {
                HayError = true;
                ErrorDescripcion = "Error de Desconexión \n";
                ErrorDescripcion += error.Message;
            }
        }


        // Indica el estado de la persistencia
        public Boolean Estado()
        {
            string mensaje = "";
            this.LimpiarEstado();
            // estado dela conexión
            switch (Conexion.State)
            {
                case System.Data.ConnectionState.Broken: mensaje = "Quebrada";
                    break;
                case System.Data.ConnectionState.Closed: mensaje = "Cerrada";
                    break;
                case System.Data.ConnectionState.Connecting: mensaje = "Conectandose";
                    break;
                case System.Data.ConnectionState.Executing: mensaje = "Ejecutando";
                    break;
                case System.Data.ConnectionState.Fetching: mensaje = "Extrayendo";
                    break;
                case System.Data.ConnectionState.Open: mensaje = "Abierta";
                    break;
            }

            // cargar la propiedad con el estado de la conexion
            ErrorDescripcion = mensaje;
            MessageBox.Show(mensaje, "iiasd", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if ((Conexion.State == ConnectionState.Open) ||
                  (Conexion.State == ConnectionState.Executing) ||
                  (Conexion.State == ConnectionState.Fetching))
                return true;
            return false;
        }

     
        public static int Instancias { set; get; }

        public bool HayTransaccion { set; get; }

        public SqlTransaction Transaccion { set; get; }

        public SqlConnection Conexion { set; get; }

        public bool HayError { set; get; }
        public string ErrorDescripcion { set; get; }

        public void LimpiarEstado()
        {
            this.ErrorDescripcion = "";
            this.HayError = false;
        }

        public void IniciarTransaccion()
        {
            if (this.HayTransaccion == false)
            {
                this.Transaccion = this.Conexion.BeginTransaction();
                this.HayTransaccion = true;
            }
        }

        public void CommitTransaccion()
        {
            if (this.HayTransaccion)
            {
                this.Transaccion.Commit();
                this.HayTransaccion = false;
            }
        }

        public void RollbackTransaccion()
        {
            if (this.HayTransaccion)
            {
                this.Transaccion.Rollback();
                this.HayTransaccion = false;
            }
        }
    }
}
