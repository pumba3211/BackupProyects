using ProyectoGPS.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarVehiculo oAgregar = new AgregarVehiculo();
            oAgregar.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            EditarVehiculo oEditarVehiculo = new EditarVehiculo(dtgVehiculos.SelectedRows[0]);
            oEditarVehiculo.ShowDialog();
        }



        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarVehiculo oEliminar = new EliminarVehiculo();
            oEliminar.Show();
        }
    }
}

