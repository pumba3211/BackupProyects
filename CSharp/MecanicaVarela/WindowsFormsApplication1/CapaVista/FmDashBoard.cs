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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        #region Metodo para instaciar los elementos
       
        public enum Formularios
        {
            AgregarRepuesto,
            EditarRepuesto,
            EliminarRepuesto,
            AgregarCliente,
            EditarCliente,
            EliminarCliente,
            Repuestos,
        }
        public void IniciarFormulario(Formularios formulario)
        {
            Form form = null;
            switch (formulario)
            {
                case Formularios.AgregarRepuesto:
                    form = new FrmAgregarRepuesto();                 
                    break;
                case Formularios.EditarRepuesto:
                    form = new FrmEditarRepuesto();
                    break;
                case Formularios.EliminarRepuesto:
                    form = new FrmEliminarRepuesto();
                    break;
                case Formularios.AgregarCliente:
                    form = new FrmAgregarCliente();
                    break;
                case Formularios.EditarCliente:
                    form = new FrmEditarClientes();
                    break;
                case Formularios.EliminarCliente:
                    form = new FrmEliminarRepuesto();
                    break;
                case Formularios.Repuestos:
                    form = new FrmRepuestos();
                    break;
                default:
                    break;
            }
            form.ShowDialog();
            
        }

        #endregion


        private void ssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarRepuesto_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.AgregarRepuesto);
        }

        private void MenuItemeditarRepuesto_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EditarRepuesto);
        }

        private void MenuItemeliminarRepuesto_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EliminarRepuesto);
        }

        private void MenuItemagregarClientes_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.AgregarCliente);
        }

        private void MenuItemeditarClientes_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EditarCliente);
        }

        private void MenuItemeliminarClientes_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.EliminarCliente);
        }

        private void repuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormulario(Formularios.Repuestos);
        }
    }
}
