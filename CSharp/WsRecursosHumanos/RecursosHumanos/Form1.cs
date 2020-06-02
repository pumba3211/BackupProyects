using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            UsuarioServicio.UsuarioServicioClient owUsuarioServico = new UsuarioServicio.UsuarioServicioClient();
            bool validar = owUsuarioServico.ValidarSession(textUser.Text, Passuser.Text);
            if (validar)
            {
                MessageBox.Show("Bienvenido", "123", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "123", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
