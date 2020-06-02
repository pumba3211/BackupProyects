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
    public partial class FrmEliminarRepuesto : Form
    {
        public FrmEliminarRepuesto()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            oRepuestosCl.EliminarRepuesto(TxtID.Text);
            if (oRepuestosCl.Is_Error)
            {
                MessageBox.Show(oRepuestosCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Repuesto elimando con exicto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
