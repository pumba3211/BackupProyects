using ProyectoGPS.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGPS.Vista
{
    public partial class AgregarVehiculo : Form
    {
        
        public AgregarVehiculo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VehiculosCL oVehiculosCl = new VehiculosCL();
            oVehiculosCl.InsertarVehiculo(txtmatricula.Text, txtmarca.Text);
            if (oVehiculosCl.IsError)
            {
                MessageBox.Show(oVehiculosCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1 oPrincipal = new Form1();
                this.Close();
                oPrincipal.Show();
                MessageBox.Show("Vehiculo agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
