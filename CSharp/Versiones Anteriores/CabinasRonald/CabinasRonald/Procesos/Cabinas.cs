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
    public class Cabinas
    {
        bool error { set; get; }
        string DescripcionError { set; get; }

        public void IngresarCabina(int NumeroCabina, int espacio,int Disponible)
        {
            String Comando = "insert Cabina(numeroCabina,Espacio,Disponible) values ('" + NumeroCabina + "','" + espacio + "','" + Disponible + "')";
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
        public void EliminarCabina(int NumeroCabina)
        {
            String Comando = "delete from Cabina where numeroCabina='" + NumeroCabina + "'";
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
        public void ModificarCabina(int NumeroCabina, int Espacio)
        {
            String Comando = "update Cabina set espacio='" + Espacio + "' where NumeroCabina='" + NumeroCabina + "'";
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
        public List<Cabina> CargarCabinas()
        {
            List<Cabina> Cabinas = new List<Cabina>();
            String Comando = "select * from Cabinas";
            SqlCommand Ejecutar = new SqlCommand(Comando, Conexion.AccederAlaConexion.Instance.Accesar.Conexion);
            SqlDataReader reader = Ejecutar.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    Cabina Cabina = new Cabina();
                    Cabina.NumeroCabina = Convert.ToInt32(reader["NumeroCabina"].ToString());
                    Cabina.Espacio = Convert.ToInt32(reader["Espacio"].ToString());
                    Cabina.Disponible = Convert.ToInt32(reader["Disponible"].ToString());
                    Cabinas.Add(Cabina);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return Cabinas;

        }
    }
}

            
