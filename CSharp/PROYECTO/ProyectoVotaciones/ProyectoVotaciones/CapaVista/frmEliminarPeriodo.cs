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
    public partial class frmEliminarPeriodo : Form
    {
        public frmEliminarPeriodo()
        {
            InitializeComponent();
            CargarPeriodos();
        }

        private void DatosCandidatos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void EliminarVotante_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Eliminar el siguiente registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (DatosPeriodos.SelectedRows.Count > 0)
                {
                    Periodo Periodo= (Periodo)DatosPeriodos.SelectedRows[0].DataBoundItem;
                    MetodosPeriodos Periodos = new MetodosPeriodos();
                    Periodos.EliminarPeriodo(Periodo.ID);//SE elimina el periodo selecciona en el datagried del archivo 
                    //periodo.tex
                    if (Periodos.Is_Error)
                    {
                        MessageBox.Show(Periodos.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.CargarPeriodos();
                    }
                }
            }
        }
        /// <summary>
        /// Se cargan todos los periodos registrados en el archivo Periodo.text
        /// </summary>
        /// 
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
    }
}
