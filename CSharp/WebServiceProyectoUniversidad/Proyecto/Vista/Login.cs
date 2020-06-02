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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
       
        private void Ingresar_Click(object sender, EventArgs e)
        {
            AdministrativoService.AdministrativosServiceClient Admin = new AdministrativoService.AdministrativosServiceClient();
            AulaService.AulaServiceClient aULA = new AulaService.AulaServiceClient();
            
            bool validar = Admin.ValidarSesion(textUser.Text, Passuser.Text);
            if (validar)
            {
                MessageBox.Show("Bienvenido", "123", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vista.frmAdministrativos.administrador.Username = textUser.Text;
                Vista.frmAdministrativos.administrador.password = Passuser.Text;
                Dasboard dasboard = new Dasboard();
                dasboard.Show();
            }
            else
            {
                MessageBox.Show("Error", "123", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
    }
}
