using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Logica;
using WindowsFormsApp1.Structures;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Juego juego = Rest.CrearBaraja(Constantes.server + Constantes.NuevaBaraja);
            if (juego != null)
            {
                if (!String.IsNullOrEmpty(juego.deck_id))
                {
                    label2.Text = juego.deck_id;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
