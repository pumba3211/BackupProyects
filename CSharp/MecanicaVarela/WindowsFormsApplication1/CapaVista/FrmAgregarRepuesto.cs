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
    public partial class FrmAgregarRepuesto : Form
    {
        public FrmAgregarRepuesto()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
         {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            oRepuestosCl.AgregarRepuesto(txtNombre.Text, txtModelo.Text, txtMarca.Text,
                (int)TxtCantidad.Value, (int)txtprecio.Value, (int)TxtImpuetso.Value,
                CheckbossGravado.Checked);               
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void CheckbossGravado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtprecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtImpuetso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labe2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        

    }
}
