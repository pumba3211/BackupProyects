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
using ProyectoVotaciones.Estructura;

namespace ProyectoVotaciones
{
    public partial class frmModificarCandidato : Form
    {
        public frmModificarCandidato()
        {
            InitializeComponent();
            CargarCandidatos();
            CargarPeriodo();
        }
        //Cargamos los datos en el datagrid de los candidatos
        public void CargarCandidatos()
        {
            MetodosCandidatos Candidatos = new MetodosCandidatos();
            DGTCandidatos.DataSource = Candidatos.ObtenerCandidatos();
            if (Candidatos.Is_Error)
            {
                MessageBox.Show(Candidatos.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" || textApellidos.Text == "" || textNombreCandidato.Text == "" ||
               textApellidos.Text == "" || textPartido.Text == "" || textVotos.Text == "" || comboBoxPeriodos.SelectedIndex.Equals(-1))
            //Pregunta si todos los componentes tienen informacion
            {
                MessageBox.Show("Ingresa Todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MetodosCandidatos NuevoCandidato = new MetodosCandidatos();
                NuevoCandidato.EditarCandidato(textID.Text, textNombreCandidato.Text, textApellidos.Text, textPartido.Text, Convert.ToInt32(textVotos.Text), comboBoxPeriodos.Text);
                CargarCandidatos();


            }
        }

        private void DGTCandidatos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = DGTCandidatos.SelectedRows[0];
                textID.Text = row.Cells[0].Value.ToString();
                textNombreCandidato.Text = row.Cells[1].Value.ToString();
                textApellidos.Text = row.Cells[2].Value.ToString();
                textPartido.Text = row.Cells[3].Value.ToString();
                textVotos.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void DGTCandidatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridViewRow row = DGTCandidatos.SelectedRows[0];

            textID.Text = row.Cells[0].Value.ToString();
            textNombreCandidato.Text = row.Cells[1].Value.ToString();
            textApellidos.Text = row.Cells[2].Value.ToString();
            textPartido.Text = row.Cells[3].Value.ToString();
            textVotos.Text = row.Cells[4].Value.ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textID.Text == "")
            {
                MessageBox.Show("No has seleccionado una id", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DGTCandidatos.RowCount == 0)
            {
                MessageBox.Show("No hay ningun candidato registrado para ingresar a esta opcion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ModificarBandera MBandera = new ModificarBandera();
                MBandera.id = textID.Text;
                MBandera.Show();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textID.Text == "")
            {
                MessageBox.Show("No has seleccionado una id", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DGTCandidatos.RowCount == 0)
            {
                MessageBox.Show("No hay ningun candidato registrado para ingresar a esta opcion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PictureBox asd = new PictureBox();

                ModificarFoto Mfoto = new ModificarFoto();
                Mfoto.IDoCedula = textID.Text;
                Mfoto.tipo = 1;
                Mfoto.Show();
            }
        }

        public void CargarPeriodo()
        {
            MetodosPeriodos Periodos = new MetodosPeriodos();
            List<Periodo> Periodo = Periodos.ObtenerPeriodos();
            comboBoxPeriodos.DataSource = Periodo;
            comboBoxPeriodos.DisplayMember = "ID";


        }
        private void comboBoxPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
