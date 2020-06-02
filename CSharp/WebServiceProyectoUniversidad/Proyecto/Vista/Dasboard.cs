using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanos.Vista;

namespace RecursosHumanos
{
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
        }
        public enum Formularios
       {
            administrativos,
            alumnos,
            aulas,
            carrera,
            grupos,
            profesores,
       }
        #region Inicio de formularios
        public void IniciarFormularios(Formularios formulario)
        {
            Form form = null;
            switch (formulario)
            {
                case Formularios.administrativos:
                    form = new frmAdministrativos();
                    break;
                case Formularios.alumnos:
                    form = new frmAlumnos();
                    break;
                case Formularios.aulas:
                    form = new frmAulas();
                    break;
                case Formularios.carrera:
                    form = new frmCarrera();
                    break;
                case Formularios.grupos:
                    form = new frmGrupos();
                    break;
                case Formularios.profesores:
                    form = new frmProfesores();
                    break;
                    default:
                    throw new ArgumentOutOfRangeException("Formulario");
            }
            form.ShowDialog();
        }

        #endregion

        private void alumnnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.alumnos);
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.profesores);
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.aulas);
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.aulas);
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.administrativos);
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarFormularios(Formularios.carrera);
        }
    }
}
