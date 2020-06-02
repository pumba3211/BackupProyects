using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appMecanicaVarela.CapaLogica;
using appMecanicaVarela.Estructura;


namespace appMecanicaVarela
{
    public partial class frmEditarRepuesto : Form
    {
        public frmEditarRepuesto(Repuesto repuesto)
        {
            InitializeComponent();
            
            txtNombre.Text = repuesto.Nombre;
            txtModelo.Text = repuesto.Modelo;
            txtMarca.Text = repuesto.Nombre;
            txtCantidad.Value = repuesto.Cantidad;
            txtPrecio.Value = (decimal)repuesto.Precio;
            txtImpuesto.Value = repuesto.Impuesto;
            chkGravado.Checked = repuesto.Gravado;
        }
        public frmEditarRepuesto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
            oRepuestosCl.Editar(txtID.Text, txtNombre.Text, txtModelo.Text, txtMarca.Text, 
                            (int)txtCantidad.Value, (int)txtPrecio.Value, 
                            (int)txtImpuesto.Value, chkGravado.Checked);
            
            if (oRepuestosCl.IsError)
            {
                MessageBox.Show(oRepuestosCl.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Repuesto Editado con EXITO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
