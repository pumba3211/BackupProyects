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
    public class Reservaciones
    {
        public void AgregarReservacion(int NCabina, String CedulaCliente, String date)
        {
            String Comando = "insert into Reservacion (NumeroCabina,CedulaCliente,Fecha) values('" + NCabina + "','" + CedulaCliente + "','" + date + "')";
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
        public void EliminarReservacion(int id)
        {
            String Comando = "delete from Reservacion where NumeroReservacion='" + id + "'";
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
        public void ModificarReservacion(int NReservacion, int Ncabina, string Cedula, String date)
        {
            String Comando="update Reservaciones set numeroCabina='"+Ncabina+"', cedulacliente='"+Cedula+"' fecha='"+date+"' where numerodeReservacion='"+NReservacion+"'";
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
        public List<Reservacion> CargarPorFechas(String date)
        {
            List<Reservacion> Reservaciones = new List<Reservacion>();
            String Comando = "select * from Reservacion where fecha='" + date + "'";
            SqlCommand Ejecutar = new SqlCommand(Comando, Conexion.AccederAlaConexion.Instance.Accesar.Conexion);
            SqlDataReader reader = Ejecutar.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    Reservacion Reservacion = new Reservacion();
                    Reservacion.NumeroReservacion = Convert.ToInt32(reader["NumeroReseracion"].ToString());
                    Reservacion.numeroCabina = Convert.ToInt32(reader["NumeroCabina"].ToString());
                    Reservacion.CedulaCliente = reader["CedulaCliente"].ToString();
                    Reservacion.Fecha = reader["Fecha"].ToString();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
            }
            return Reservaciones;
        }
        public List<Reservacion> CargarPorIntervalodeFechas(String date,String date2)
        {
            List<Reservacion> Reservaciones = new List<Reservacion>();
            String Comando = "select * from Reservacion where fecha='" + date + "'";
            SqlCommand Ejecutar = new SqlCommand(Comando, Conexion.AccederAlaConexion.Instance.Accesar.Conexion);
            SqlDataReader reader = Ejecutar.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    Reservacion Reservacion = new Reservacion();
                    Reservacion.NumeroReservacion = Convert.ToInt32(reader["NumeroReseracion"].ToString());
                    Reservacion.numeroCabina = Convert.ToInt32(reader["NumeroCabina"].ToString());
                    Reservacion.CedulaCliente = reader["CedulaCliente"].ToString();
                    Reservacion.Fecha = reader["Fecha"].ToString();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return Reservaciones;
        }
    }

}
