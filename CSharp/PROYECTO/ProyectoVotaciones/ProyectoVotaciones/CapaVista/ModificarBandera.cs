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
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones.CapaVista
{
    public partial class ModificarBandera : Form
    {
        public string id { set; get; }
        MetodosCandidatos Candidatos = new MetodosCandidatos();

        public ModificarBandera()
        {
            InitializeComponent();

        }


        private void Escoger_Click(object sender, EventArgs e)
        {
            openBandera.ShowDialog();
            if (openBandera.FileName != "")
            {
                EspacioBandera.Image = Image.FromFile(openBandera.FileName);
            }
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (EspacioBandera.Image == null)
            {
                MessageBox.Show("Debes Seleccionar una foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Candidatos.BorrarBandera(id);
                EspacioBandera.Image.Save(UrlArchivos.CandidatosCarpeta + "BANDERA" + id + ".JPEG");
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
