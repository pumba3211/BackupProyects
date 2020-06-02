using appMecanicaVarela.CapaLogica;
using appMecanicaVarela.Estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMecanicaVarela
{
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();
            this.TraerDatos();
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }
        private void TraerDatos()
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            dtgRepuestos.DataSource = oRepuestosCl.ObtenerRepuestos();

            if (oRepuestosCl.IsError)
            {
                MessageBox.Show(oRepuestosCl.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
          
        }

        private void grbFiltro_Enter(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarRepuesto oAgregarRepuesto = new frmAgregarRepuesto();
            oAgregarRepuesto.ShowDialog();
            this.TraerDatos();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarRepuesto oEditarRepuesto = new frmEditarRepuesto();
            oEditarRepuesto.ShowDialog();
            this.TraerDatos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (DialogResult.Yes == MessageBox.Show("Desea Eliminar el siguiente registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgRepuestos.SelectedRows.Count > 0)
                {
                    Repuesto repuesto = (Repuesto)dtgRepuestos.SelectedRows[0].DataBoundItem;
                    RepuestosCL oRepuestosCl = new RepuestosCL();
                    oRepuestosCl.EliminarRepuesto(repuesto.Id);

                    if (oRepuestosCl.IsError)
                    {
                        MessageBox.Show(oRepuestosCl.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.TraerDatos();
                    }
                }
                

            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            List<Repuesto> repuestos = oRepuestosCl.ObtenerRepuestos();
            repuestos = repuestos.Where(x => x.Id.Contains(txtFiltro.Text)).ToList();
            dtgRepuestos.DataSource = repuestos;

            if (oRepuestosCl.IsError)
            {
                MessageBox.Show(oRepuestosCl.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

           
        }
    }
}
