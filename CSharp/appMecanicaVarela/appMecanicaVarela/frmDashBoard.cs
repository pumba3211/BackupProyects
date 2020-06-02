using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMecanicaVarela
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        #region Metodos para inicializar formularios

        public enum Formularios
        {
            AgregarRespuesto,
            EditarRepuesto,
            EliminarRepuesto,
            Repuestos,

            AgregarCliente,
            EditarCliente,
            EliminarCliente
        }

        public void IniciarFormulario(Formularios formulario)
        {
            Form form = null;

            switch (formulario)
            {           
                case Formularios.AgregarRespuesto:
                    form = new frmAgregarRepuesto();
                    break;
                case Formularios.EditarRepuesto:
                    form = new frmEditarRepuesto();
                    break;
                case Formularios.EliminarRepuesto:
                    form = new frmEliminarRepuesto();
                    break;
                case Formularios.Repuestos:
                    form = new frmRepuestos();
                    break;
                case Formularios.AgregarCliente:
                    form = new frmAgregarCliente();
                    break;
                case Formularios.EditarCliente:
                    form = new frmEditarCliente();
                    break;
                case Formularios.EliminarCliente:
                    form = new frmEliminarCliente();
                    break;
                default:
                    break;
            }
            form.ShowDialog();
        }
        
        #endregion


        private void MenuItemAgregarRepuesto_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.AgregarRespuesto);
        }

        private void MenuItemEditarRepuesto_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EditarRepuesto);
        }

        private void MenuItemEliminarRepuesto_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EliminarRepuesto);
        }

        private void MenuItemAgregarClientes_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.AgregarCliente);
        }

        private void MenuItemEditarClientes_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EditarCliente);
        }

        private void MenuItemEliminarClientes_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EliminarCliente);
        }

        private void repuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.Repuestos);
        }
    }
}
