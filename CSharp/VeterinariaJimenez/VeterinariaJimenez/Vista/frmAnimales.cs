using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaJimenez.Logica;
using VeterinariaJimenez.Logica.SQL;

namespace VeterinariaJimenez.Vista
{
    public partial class frmAnimales : Form
    {      
        public frmAnimales()
        {
            InitializeComponent();
            
            CargarDatos();
            dtgAnimales.AutoGenerateColumns = false;
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            AnimalesCL oAnimalesCL = new AnimalesCL();
            DataSet odatos = oAnimalesCL.TraerAnimales(txtBuscar.Text);
           
            if (oAnimalesCL.IsError)
            {
                MessageBox.Show(oAnimalesCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtgAnimales.DataSource=odatos.Tables[0];
            }

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarAnimal oAgregarAnimal = new frmAgregarAnimal();
            oAgregarAnimal.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgAnimales.SelectedRows.Count > 0)
            {
                frmEditarAnimales oEditarAnomales = new frmEditarAnimales(dtgAnimales.SelectedRows[0]);
                oEditarAnomales.ShowDialog();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgAnimales.SelectedRows.Count > 0)
            {
                AnimalesCL oAnimales = new AnimalesCL();
                oAnimales.EliminarAnimal(Convert.ToInt32(dtgAnimales.SelectedRows[0].Cells[0].Value));
                if (oAnimales.IsError)
                {
                    MessageBox.Show(oAnimales.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Animal Eliminado", "Inforamcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.CargarDatos();
            }
        }
    }
}
