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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if ((TextUser.Text == "admin") && (textclave.Text == "12345"))
            {
                 //MessageBox.Show("Gracias por ingresar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                DashBoard oDashBoard = new DashBoard();
                oDashBoard.Show();
            }
            else
            {
                MessageBox.Show("Usuario y clave errornea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
