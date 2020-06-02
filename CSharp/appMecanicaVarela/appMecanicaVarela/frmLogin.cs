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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "admin") && (txtContraseña.Text == "12345"))
            {
                //MessageBox.Show("GRACIAS POR INGRESAR", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmDashBoard oDash = new frmDashBoard();
                oDash.Show();
            }
            else
            {
                MessageBox.Show("USUARIO Y CLAVE INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
