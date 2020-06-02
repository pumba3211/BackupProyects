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
    public partial class frmEditarAnimales : Form
    {
        
        public frmEditarAnimales(DataGridViewRow row)
        {
            InitializeComponent();
            textID.Text = row.Cells[0].Value.ToString();
            textNombre.Text = row.Cells[1].Value.ToString();
            comboBoxEspecie.SelectedIndex = Convert.ToInt32(row.Cells[2].Value);
            comboBoxTipo.SelectedIndex = Convert.ToInt32(row.Cells[3].Value);
            textDueño.Text = row.Cells[4].Value.ToString();

            
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            AnimalesCL oAnimalesCl = new AnimalesCL();
            oAnimalesCl.EditarAnimal(Convert.ToInt32(textID.Text),textNombre.Text, comboBoxEspecie.SelectedIndex, comboBoxTipo.SelectedIndex, textDueño.Text);
            if (oAnimalesCl.IsError)
            {
                MessageBox.Show(oAnimalesCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Animal Editado", "Inforamcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
