using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ProyectoVotaciones.CapaLogica;
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones.CapaVista
{
    public partial class ModificarFoto : Form
    {
        public string IDoCedula { set; get; }
        public int tipo { set; get; }
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        MetodosCandidatos Candidatos = new MetodosCandidatos();
        MetodosVotantes Votantes = new MetodosVotantes();
        public ModificarFoto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        #region manejo de camara
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();

        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            ESpacioCamara.Image = Imagen;

        }
        #endregion
        private void frmAgregarCandidato_Load(object sender, EventArgs e)
        {

        }

        private void Existente_Click(object sender, EventArgs e)
        {
            AbrirFoto.ShowDialog();
            if (AbrirFoto.FileName != "")
            {
                ESpacioCamara.Image = Image.FromFile(AbrirFoto.FileName);
            }
        }
        public void CambiarImagen()
        {
            if (ESpacioCamara.Image == null)
            {
                MessageBox.Show("Debes Ingresar una foto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipo == 1)
            {
                Candidatos.BorrarFotoCandidato(IDoCedula);
                ESpacioCamara.Image.Save(UrlArchivos.CandidatosCarpeta + IDoCedula + ".JPEG");
            }
            else
            {
                Votantes.BorrarFotoVotante(IDoCedula);
                ESpacioCamara.Image.Save(UrlArchivos.VotantesCarpeta + IDoCedula + ".JPEG");
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            {
                if (btnIniciar.Text == "Iniciar")
                {
                    if (ExisteDispositivo)
                    {
                        FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
                        FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                        FuenteDeVideo.Start();
                        Estado.Text = "Ejecutando Dispositivo…";
                        btnIniciar.Text = "Detener";
                        cbxDispositivos.Enabled = false;
                        groupcamara.Text = DispositivoDeVideo[cbxDispositivos.SelectedIndex].Name.ToString();
                    }
                    else
                        Estado.Text = "Error: No se encuenta el Dispositivo";
                }
                else
                {
                    if (FuenteDeVideo.IsRunning)
                    {
                        TerminarFuenteDeVideo();
                        Estado.Text = "Dispositivo Detenido…";
                        btnIniciar.Text = "Iniciar";
                        cbxDispositivos.Enabled = true;
                    }
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            CambiarImagen();
            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}









