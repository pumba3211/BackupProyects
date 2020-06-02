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

namespace ProyectoVotaciones
{
    public partial class frmAgregarCandidato : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public string IDPeriodo { set; get; }//Se manda el id del periodo que esta activo 
        public frmAgregarCandidato()
        {
            InitializeComponent();
            BuscarDispositivos();
        }
        #region manejo de camara
        /// <summary>
        /// Se cargan los dispositivos que hay en el pc  que sean camaras y se asignan al combox
        /// </summary>
        /// <param name="Dispositivos"></param>
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

        /// <summary>
        /// Metodo que inicia la camara web y detienen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Se utiliza para carhar un archivo existe y se guarda en el picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            openBandera.ShowDialog();
            if (openBandera.FileName != "")
            {
                EspacioBandera.Image = Image.FromFile(openBandera.FileName);
            }
        }


        /// <summary>
        /// Metodo que usamos para ingresar el candidato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void botonIngresarCandidato_Click(object sender, EventArgs e)
        {
            MetodosCandidatos NuevoCandidato = new MetodosCandidatos();
            List<Candidato> ListaCandidatos = NuevoCandidato.ObtenerCandidatos();
            if (textID.Text == "" || textApellidos.Text == "" || textNombreCandidato.Text == "" ||
               textApellidos.Text == "" || textPartido.Text == "" || ESpacioCamara.Image == null || EspacioBandera.Image == null)//Se comprueba si todos
            //los componentes que se utilizan para agregar datos estan completos o tienen inforamcion para que no haya problemas a la hora de agregar
            {
                MessageBox.Show("Ingresa Todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool esta = false;
                for (int i = 0; i < ListaCandidatos.Count; i++)//Se comprueba si hay candidatos 
                {
                    if (ListaCandidatos[i].ID == textID.Text)//Se comprueba si el textid y el id de la posicion de la longitud de la lista son iguales
                    //de serlo quiere decir que ese id ya esta asignando a otro candidato
                    {
                        esta = true;
                        break;
                    }
                }
                if (esta == true)
                {
                    MessageBox.Show("Ese Candidato ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textID.Text = "";
                }
                else
                {
                    NuevoCandidato.AgregarCandidato(textID.Text, textNombreCandidato.Text, textApellidos.Text, textPartido.Text, 0, IDPeriodo);//Se agrega toda la informacion 
                    ESpacioCamara.Image.Save(UrlArchivos.CandidatosCarpeta + textID.Text + ".JPEG");//Agremos la foto en el la ruta 
                    EspacioBandera.Image.Save(UrlArchivos.CandidatosCarpeta + "BANDERA" + textID.Text + ".JPEG");//Se agrega la bandera en la misma ruta que la foto
                    this.Close();
                }

            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
