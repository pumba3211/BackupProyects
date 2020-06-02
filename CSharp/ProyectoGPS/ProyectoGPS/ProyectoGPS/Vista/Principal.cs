using ProyectoGPS.Logica;
using ProyectoGPS.Logica.Postgrest;
using ProyectoGPS.Logica.SQL;
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
        int cont;
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
            dtgVehiculos.AutoGenerateColumns = false;
            cont = dtgVehiculos.RowCount;
        }

        private void CargarDatos()
        {
            VehiculosCL oVehiculosCL = new VehiculosCL();
            DataSet odatos = oVehiculosCL.TraerVehiculo(txtBuscar.Text);

            if (oVehiculosCL.IsError)
            {
                MessageBox.Show(oVehiculosCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtgVehiculos.DataSource = odatos.Tables[0];
            }

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarVehiculo oAgregar = new AgregarVehiculo();
            this.Hide();
            oAgregar.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtgVehiculos.SelectedRows.Count > 0)
            {
                EditarVehiculo oEditarVehiculo = new EditarVehiculo(dtgVehiculos.SelectedRows[0]);
                this.Hide();
                oEditarVehiculo.ShowDialog();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgVehiculos.SelectedRows.Count > 0)
            {
                EditarVehiculo oEditarVehiculos = new EditarVehiculo(dtgVehiculos.SelectedRows[0]);
                this.Hide();
                oEditarVehiculos.ShowDialog();
            } 
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgVehiculos.SelectedRows.Count > 0)
            {
                VehiculosCL oVehiculo = new VehiculosCL();
                oVehiculo.EliminarVehiculo((dtgVehiculos.SelectedRows[0].Cells[0]).Value.ToString());
                if (oVehiculo.IsError)
                {
                    MessageBox.Show(oVehiculo.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vehiculo Eliminado", "Inforamcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.CargarDatos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IVehiculosSql Post=new VehiculosPostgres();

            for (int i = 0; i < dtgVehiculos.RowCount; i++)
            {
                {
                    Post.InsertarVehiculo(dtgVehiculos.Rows[i].Cells[0].Value.ToString(), dtgVehiculos.Rows[i].Cells[1].Value.ToString());
                    
                }
            }
           
        }
               

    }
}

