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

namespace ProyectoVotaciones
{
    public partial class frmEliminarVotante : Form
    {
        public frmEliminarVotante()
        {
            InitializeComponent();

            CargarVotantes();
        }

        private void EliminarVotante_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Eliminar el siguiente registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (DGTVotantes.SelectedRows.Count > 0)
                {
                    Votante Votante = (Votante)DGTVotantes.SelectedRows[0].DataBoundItem;
                    MetodosVotantes Votantes = new MetodosVotantes();
                    Votantes.EliminarVotante(Votante.Cedula);//Se elimina el votante de Votantes.text
                    Votantes.BorrarFotoVotante(Votante.Cedula);//Se elimina la foto del votante

                    if (Votantes.Is_Error)
                    {
                        MessageBox.Show(Votantes.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.CargarVotantes();
                    }
                }
            }
        }
        /// <summary>
        /// Se cargan los votantes del archivo Votantes.text
        /// </summary>
        public void CargarVotantes()
        {

            MetodosVotantes Votantes = new MetodosVotantes();
            DGTVotantes.DataSource = Votantes.ObtenerVotantes();
            if (Votantes.Is_Error)
            {
                MessageBox.Show(Votantes.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
