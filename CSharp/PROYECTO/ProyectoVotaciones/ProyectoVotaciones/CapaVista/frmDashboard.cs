using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoVotaciones.CapaLogica;
using ProyectoVotaciones.CapaVista;
using ProyectoVotaciones.Estructura;
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones
{
    public partial class frmDashboard : Form
    {
        public bool ComprobarAdmistradorVoto { set; get; }//Se compreba si el administrador puede votar
        public string CedAdmin { set; get; }
        public frmDashboard()
        {
            InitializeComponent();


        }
        public void AdmistridaroPuedeVotar()
        {

        }

        public enum Formularios
        {



            EliminarCandidato,
            ModificarCandidato,

            AgregarVotante,
            EliminarVotante,
            ModificarVotante,

            AgregarPeriodo,
            EliminarPeriodo,
            ModificarPeriodo,

        }

        #region Inicio de formularios
        public void IniciarFormularios(Formularios formulario)
        {
            Form form = null;
            switch (formulario)
            {

                case Formularios.EliminarCandidato:
                    form = new frmEliminarCandidato();
                    break;
                case Formularios.ModificarCandidato:
                    form = new frmModificarCandidato();
                    break;
                case Formularios.AgregarVotante:
                    form = new frmAgregarVotante();
                    break;
                case Formularios.EliminarVotante:
                    form = new frmEliminarVotante();
                    break;
                case Formularios.ModificarVotante:
                    form = new frmModificarVotante();
                    break;
                case Formularios.AgregarPeriodo:
                    form = new frmAgregarPeriodo();
                    break;
                case Formularios.EliminarPeriodo:
                    form = new frmEliminarPeriodo();
                    break;
                case Formularios.ModificarPeriodo:
                    form = new frmModificarPeriodo();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Formulario");
            }
            form.ShowDialog();
        }

        #endregion

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
        #region Evitir voto
        private void eMITIRVOTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!File.Exists(UrlArchivos.Periodo) || !File.Exists(UrlArchivos.Candidatos))
            {
                //No se podra ingresar al formulario votar si no hay periodos o candidatos registrados
                MessageBox.Show("No se ha creado ningun periodo o candidatos en el periodo que usas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetodosPeriodos Periodos = new MetodosPeriodos();
                List<Periodo> Periodo = Periodos.ObtenerPeriodos();
                frmEmitirVoto Votos = new frmEmitirVoto();
                Votos.CedulaVotante = CedAdmin;
                bool Hayperiodoactivo = false;
                string IDPeriodo = "";
                for (int i = 0; i < Periodo.Count; i++)
                {
                    if (Periodo[i].Uso == "Si")
                    {
                        Hayperiodoactivo = true;
                        IDPeriodo = Periodo[i].ID;
                        break;
                    }
                }
                if (Hayperiodoactivo == true)//Se comprueba si hay algun periodo activo de los registrados de serlo al formulario de votos
                //se le asigan el IDperiodo a usar
                {
                    Votos.IDPeriodo = IDPeriodo;
                    Votos.Show();
                }
                else
                {
                    MessageBox.Show("No Hay Periodos Activos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        #region Resulados
        private void rESULTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //No se podra ingresar al formulario resultados si no hay periodos o candidatos registrados
            if (!File.Exists(UrlArchivos.Periodo) || !File.Exists(UrlArchivos.Candidatos))
            {
                MessageBox.Show("No se ha creado ningun periodo o candidatos en el periodo que usas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetodosPeriodos Periodos = new MetodosPeriodos();
                List<Periodo> Periodo = Periodos.ObtenerPeriodos();
                frmResultados Resultados = new frmResultados();
                bool Hayperiodoactivo = false;
                string IDPeriodo = "";
                for (int i = 0; i < Periodo.Count; i++)
                {
                    if (Periodo[i].Uso == "Si")
                    {
                        Hayperiodoactivo = true;
                        IDPeriodo = Periodo[i].ID;
                        break;
                    }
                }
                if (Hayperiodoactivo == true)
                {
                    Resultados.IDPeriodo = IDPeriodo;
                    Resultados.Show();
                }
                else
                {
                    MessageBox.Show("No Hay Periodos Activos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }
        #endregion

        #region
        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(UrlArchivos.Periodo))
            {
                MessageBox.Show("No se ha creado ningun periodo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //No se podra ingresar al formulario de agregar candidatos si no hay periodos 
            }
            else
            {
                MetodosPeriodos Periodos = new MetodosPeriodos();
                List<Periodo> Periodo = Periodos.ObtenerPeriodos();

                bool Hayperiodoactivo = false;
                string IDPeriodo = "";
                for (int i = 0; i < Periodo.Count; i++)
                {
                    if (Periodo[i].Uso == "Si")
                    {
                        Hayperiodoactivo = true;
                        IDPeriodo = Periodo[i].ID;
                        break;
                    }
                }
                if (Hayperiodoactivo == true)
                {
                    frmAgregarCandidato AgregarCandidato = new frmAgregarCandidato();
                    AgregarCandidato.IDPeriodo = IDPeriodo;
                    AgregarCandidato.Show();
                }
                else
                {
                    MessageBox.Show("No Hay Periodos Activos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.EliminarCandidato);
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.ModificarCandidato);
        }

        private void aGREGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.AgregarVotante);
        }

        private void eLIMINARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.EliminarVotante);
        }

        private void mODIFICARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.ModificarVotante);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void candidatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Directorios Directorio = new Directorios();
            Directorio.HacerBackup();
        }

        private void vOTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void votantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Directorios Directorio = new Directorios();
            Directorio.Extraer();
        }

        private void aGREGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.AgregarPeriodo);
        }

        private void eLIMINARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.EliminarPeriodo);
        }

        private void mODIFICARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.ModificarPeriodo);
        }

    }
}
