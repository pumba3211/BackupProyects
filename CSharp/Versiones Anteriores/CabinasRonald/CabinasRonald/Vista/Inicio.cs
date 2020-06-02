using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinasRonald.Vista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_MouseEnter(object sender, EventArgs e)
        {
           
        }
        private void Inicio_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @Application.StartupPath + "\\Imagenes\\Tille2.PNG";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @Application.StartupPath + "\\Imagenes\\Tille1.PNG";

        }

        private void Cancelar_MouseEnter(object sender, EventArgs e)
        {
            Cancelar.Image = Image.FromFile(@Application.StartupPath + "\\Imagenes\\Cancelar2.PNG");
        }

        private void Cancelar_MouseLeave(object sender, EventArgs e)
        {
            Cancelar.Image = Image.FromFile(@Application.StartupPath + "\\Imagenes\\Cancelar1.PNG");
        }

        private void Ingresar_MouseEnter(object sender, EventArgs e)
        {
            Ingresar.Image = Image.FromFile(@Application.StartupPath + "\\Imagenes\\Ingresar2.PNG");
        }

        private void Ingresar_MouseLeave(object sender, EventArgs e)
        {
            
            Ingresar.Image= Image.FromFile(@Application.StartupPath + "\\Imagenes\\Ingresar1.PNG");
            
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["Usuario"].Equals(Usuario.Text) &&
                        ConfigurationManager.AppSettings["Password"].Equals(Pass.Text))
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("El usuario ingresado es erroneo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }
         
    }
}
