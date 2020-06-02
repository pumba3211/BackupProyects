using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanicaVarela
{
    public partial class FrmEditarRepuesto : Form
    {
        public FrmEditarRepuesto()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            oRepuestosCl.EditarRepuesto(TxtID.Text,txtNombre.Text, txtModelo.Text, txtMarca.Text,
                (int)TxtCantidad.Value, (int)txtprecio.Value, (int)TxtImpuetso.Value,
                CheckbossGravado.Checked);
            if (oRepuestosCl.Is_Error)
            {
                MessageBox.Show(oRepuestosCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Repuesto editado con exito","Correcto", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
