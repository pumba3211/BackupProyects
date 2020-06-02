using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appMecanicaVarela.CapaLogica;

namespace appMecanicaVarela
{
    public partial class frmEliminarRepuesto : Form
    {
        public frmEliminarRepuesto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            oRepuestosCl.EliminarRepuesto(txtID.Text);

            if (oRepuestosCl.IsError)
            {
                MessageBox.Show(oRepuestosCl.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }else
            {
                MessageBox.Show("Repuesto Eliminado con EXITO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
