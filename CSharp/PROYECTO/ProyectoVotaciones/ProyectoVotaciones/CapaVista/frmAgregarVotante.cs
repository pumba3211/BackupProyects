using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ProyectoVotaciones.CapaLogica;
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones
{
    public partial class frmAgregarVotante : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        String cdireccion;
        public frmAgregarVotante()
        {
            InitializeComponent();
            CheckBox asd = new CheckBox();
            Label label = new Label();
            CheckBox asd1 = new CheckBox();
            Label label2 = new Label();
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

        private void botonAgregarVotante_Click(object sender, EventArgs e)
        {
            MetodosVotantes NuevoVotante = new MetodosVotantes();
            List<Votante> ListaVotantes = NuevoVotante.ObtenerVotantes();
            if (textCedula.Text == "" || textApellido1.Text == "" || textApellido2.Text == "" || textNombre.Text == "" || comboPrivilegios.SelectedIndex.Equals(-1))
            //Se comprueba si los componente para ingresar tienen informacion
            {
                MessageBox.Show("Ingresa Todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool esta = false;
                for (int i = 0; i < ListaVotantes.Count; i++)
                {
                    if (ListaVotantes[i].Cedula == textCedula.Text)//Se comprueba si la cedula ingresada ya esta de serlo esta se hace true y se compara luego
                    {
                        esta = true;
                        break;
                    }
                }
                if (esta == true)
                {
                    MessageBox.Show("Ese usuario ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCedula.Text = "";
                }
                else
                {
                    if (ESpacioCamara.Image == null)
                    {
                        MessageBox.Show("Debes agregar una foto de Votante", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        NuevoVotante.GenerarContraseña();//Se genera la contraseña del votante
                        contraseña.Text = NuevoVotante.contraseña;//
                        NuevoVotante.AgregarVotante(textCedula.Text, comboPrivilegios.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, "No");//Se guarda toda la informacion
                        ESpacioCamara.Image.Save(UrlArchivos.VotantesCarpeta + textCedula.Text + ".JPEG");//Se agregar la foto del picturebox
                    }
                    this.Close();
                }
            }
        }

        private void comboPrivilegios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
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

        private void Existente_Click(object sender, EventArgs e)
        {
            OpenAgregarFoto.ShowDialog();
            if (OpenAgregarFoto.FileName != "")
            {
                ESpacioCamara.Image = Image.FromFile(OpenAgregarFoto.FileName);
            }
        }
    }
}




