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
using ProyectoVotaciones.Estructura;

namespace ProyectoVotaciones.CapaVista
{
    public partial class frmModificarPeriodo : Form
    {
        public frmModificarPeriodo()
        {
            InitializeComponent();
            CargarPeriodos();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            MetodosPeriodos Periodos = new MetodosPeriodos();
            if (textID.Text == "" || textAñoI.Text == "" || textAñoF.Text == "" || comboBoxUso.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Ingresa Todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<Periodo> Periodo = new List<Periodo>();
                bool Hayperiodoactivo = false;
                for (int i = 0; i < Periodo.Count; i++)
                {
                    if (Periodo[i].Uso == "Si")
                    {
                        Hayperiodoactivo = true;
                        break;
                    }
                }
                if (Hayperiodoactivo == true)
                {
                    MessageBox.Show("Ya hay un periodo activo no se pueden tener 2", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Periodos.EditarPeriodo(textID.Text, textAñoI.Text, textAñoF.Text, comboBoxUso.Text);
                    CargarPeriodos();
                }
            }
        }

        public void CargarPeriodos()
        {
            MetodosPeriodos Periodos = new MetodosPeriodos();
            DatosPeriodos.DataSource = Periodos.ObtenerPeriodos();
            if (Periodos.Is_Error)
            {
                MessageBox.Show(Periodos.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosPeriodos_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row = DatosPeriodos.SelectedRows[0];
            textID.Text = row.Cells[0].Value.ToString();
            textAñoI.Text = row.Cells[1].Value.ToString();
            textAñoF.Text = row.Cells[2].Value.ToString();
        }
    }
}
