using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoVotaciones.CapaLogica;
using ProyectoVotaciones.CapaVista;

namespace ProyectoVotaciones
{
    public partial class frmModificarVotante : Form
    {
        public frmModificarVotante()
        {
            InitializeComponent();
            CargarVotantes();

        }

        private void DGTVotantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGTVotantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void textCedula_TextChanged(object sender, EventArgs e)
        {
        }

        public void CargarVotantes()
        {

            MetodosVotantes Votantes = new MetodosVotantes();
            DGTVotantes.DataSource = Votantes.ObtenerVotantes();

            if (Votantes.Is_Error)
            {
                MessageBox.Show(Votantes.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void DGTVotantes_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row = DGTVotantes.SelectedRows[0];
            textCedula.Text = row.Cells[0].Value.ToString();
            textContraseña.Text = row.Cells[1].Value.ToString();
            textNombre.Text = row.Cells[3].Value.ToString();
            textApellido1.Text = row.Cells[4].Value.ToString();
            textApellido2.Text = row.Cells[5].Value.ToString();
            textVoto.Text = row.Cells[6].Value.ToString();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            MetodosVotantes NuevoVotante = new MetodosVotantes();
            List<Votante> ListaVotantes = NuevoVotante.ObtenerVotantes();
            if (textCedula.Text == "" || textApellido1.Text == "" || textApellido2.Text == "" || textNombre.Text == "" || comboPrivilegios.SelectedIndex.Equals(-1)
                || textContraseña.Text == "" || textVoto.Text == "")
            {
                MessageBox.Show("Ingresa Todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NuevoVotante.EditarVotante(textCedula.Text, textContraseña.Text, comboPrivilegios.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, textVoto.Text);
                CargarVotantes();
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textCedula.Text == "")
            {
                MessageBox.Show("No has seleccionado una id", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DGTVotantes.RowCount == 0)
            {
                MessageBox.Show("No hay ningun candidato registrado para ingresar a esta opcion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ModificarFoto Mfoto = new ModificarFoto();
                Mfoto.IDoCedula = textCedula.Text;
                Mfoto.tipo = 2;
                Mfoto.Show();
            }
        }
    }
}




