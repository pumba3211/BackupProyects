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

namespace ProyectoVotaciones
{
    public partial class frmEliminarCandidato : Form
    {
        public frmEliminarCandidato()
        {
            InitializeComponent();
            CargarCandidatos();
        }

        private void EliminarCandidato_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Eliminar el siguiente registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (DatosCandidatos.SelectedRows.Count > 0)
                {
                    Candidato Candidato = (Candidato)DatosCandidatos.SelectedRows[0].DataBoundItem;
                    MetodosCandidatos Candidatos = new MetodosCandidatos();
                    Candidatos.EliminarCandidato(Candidato.ID);//Se borra el candidato del archivo Candidatos.text
                    Candidatos.BorrarBandera(Candidato.ID);//SE ELIMINA LA BANDERA DEL CANDIDATO
                    Candidatos.BorrarFotoCandidato(Candidato.ID);//SE ELIMINA LA FOTO DEL CANDIDATO

                    if (Candidatos.Is_Error)
                    {
                        MessageBox.Show(Candidatos.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.CargarCandidatos();
                    }
                }
            }
        }
        /// <summary>
        /// Cargamos los datos en el datagridviem de los candidatos registrados
        /// </summary>
        /// 
        public void CargarCandidatos()
        {
            MetodosCandidatos Candidatos = new MetodosCandidatos();
            DatosCandidatos.DataSource = Candidatos.ObtenerCandidatos();
            if (Candidatos.Is_Error)
            {
                MessageBox.Show(Candidatos.ErrorDescripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);



            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
