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

namespace VeterinariaJimenez.Vista
{
    public partial class frmAgregarAnimal : Form
    {
        public frmAgregarAnimal()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            AnimalesCL oAnimalesCl = new AnimalesCL();
            oAnimalesCl.InsertarAnimal(textNombre.Text, comboBoxEspecie.SelectedIndex, comboBoxTipo.SelectedIndex, textDueño.Text);
            if (oAnimalesCl.IsError)
            {
                MessageBox.Show(oAnimalesCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Animal agredado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textDueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
