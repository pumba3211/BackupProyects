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
    public partial class frmAgregarRepuesto : Form
    {
        public frmAgregarRepuesto()
        {
            InitializeComponent();
        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            oRepuestosCl.AgregarRepuesto(txtNombre.Text, txtModelo.Text, txtMarca.Text, (int)txtCantidad.Value,
                (int)txtPrecio.Value, (int)txtImpuesto.Value, chkGravado.Checked);

            if (oRepuestosCl.IsError)
            {
                MessageBox.Show(oRepuestosCl.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
