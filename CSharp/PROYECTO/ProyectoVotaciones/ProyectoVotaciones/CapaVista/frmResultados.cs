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

namespace ProyectoVotaciones
{
    public partial class frmResultados : Form
    {
        int Total_votos = 0;
        int primer_lugar = 0;
        int segundo_lugar = 0;
        int tercer_lugar = 0;
        int final = 0;
        MetodosNulosBlancos NB = new MetodosNulosBlancos();
        public string IDPeriodo { set; get; }
        List<NulosBlancos> NBS;
        public frmResultados()
        {
            InitializeComponent();

        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            MetodosCandidatos candidato = new MetodosCandidatos();
            List<Candidato> ListaCandidato = candidato.ObtenerCandidatos();
            NB.IDPeriodo = IDPeriodo;
            NBS = NB.ObtenerNulosOBlancos();
            for (int i = 0; i < ListaCandidato.Count; i++)
            {
                if (ListaCandidato[i].IDPeriodo == IDPeriodo)
                {
                    if (primer_lugar < ListaCandidato[i].Votos)
                    {
                        tercer_lugar = segundo_lugar;
                        segundo_lugar = primer_lugar;
                        primer_lugar = ListaCandidato[i].Votos;
                    }
                    else
                    {
                        if (segundo_lugar < ListaCandidato[i].Votos)
                        {
                            tercer_lugar = segundo_lugar;
                            segundo_lugar = ListaCandidato[i].Votos;
                        }
                        else
                        {
                            if (tercer_lugar < ListaCandidato[i].Votos)
                            {
                                tercer_lugar = ListaCandidato[i].Votos;
                            }
                        }
                    }

                    this.CharGraficos.Series["Porcentaje de votos"].Points.AddXY(ListaCandidato[i].Nombre + " " + ListaCandidato[i].Votos, Convert.ToDouble(ListaCandidato[i].Votos));
                    Total_votos = Total_votos + Convert.ToInt16(ListaCandidato[i].Votos);
                }
            }

            this.CharGraficos.Series["Porcentaje de votos"].Points.AddXY(NBS[0].ID + " " + NBS[0].Votos, Convert.ToDouble((NBS[0].Votos)));
            Total_votos = Total_votos + Convert.ToInt16((NBS[0].Votos));
            this.CharGraficos.Series["Porcentaje de votos"].Points.AddXY(NBS[1].ID + " " + NBS[1].Votos, Convert.ToDouble((NBS[1].Votos)));
            Total_votos = Total_votos + Convert.ToInt16((NBS[1].Votos));
            double porcentajea;
            porcentajea = (Convert.ToDouble(NBS[0].Votos) * 100) / Total_votos;
            this.charporcentaje.Series["Porcentaje de votos"].Points.AddXY(NBS[0].ID + " " + string.Format("{0:0.00}", porcentajea), porcentajea);
            porcentajea = (Convert.ToDouble(NBS[1].Votos) * 100) / Total_votos;
            this.charporcentaje.Series["Porcentaje de votos"].Points.AddXY(NBS[1].ID + " " + string.Format("{0:0.00}", porcentajea), porcentajea);

            for (int i = 0; i < ListaCandidato.Count; i++)
            {
                try
                {
                    if (ListaCandidato[i].IDPeriodo == IDPeriodo)
                    {
                        if (ListaCandidato[i].Votos == primer_lugar)
                        {
                            pictureprimero.Image = Image.FromFile((UrlArchivos.CandidatosCarpeta + ListaCandidato[i].ID + ".JPEG"));
                            lblprimero.Text = ListaCandidato[i].Nombre;
                        }
                        if (ListaCandidato[i].Votos == segundo_lugar)
                        {
                            picturesegundo.Image = Image.FromFile((UrlArchivos.CandidatosCarpeta + ListaCandidato[i].ID + ".JPEG"));
                            lblsegundo.Text = ListaCandidato[i].Nombre;
                        }
                        if (ListaCandidato[i].Votos == tercer_lugar)
                        {
                            picturetercero.Image = Image.FromFile((UrlArchivos.CandidatosCarpeta + ListaCandidato[i].ID + ".JPEG"));
                            lbltercero.Text = ListaCandidato[i].Nombre;
                        }
                    }
                }
                catch (Exception)
                {


                }

            }
            textCantidadVotos.Text = Convert.ToString(Total_votos);
            for (int i = 0; i < ListaCandidato.Count; i++)
            {
                if (ListaCandidato[i].IDPeriodo == IDPeriodo)
                {
                    double porcentaje;
                    porcentaje = (Convert.ToDouble(ListaCandidato[i].Votos) * 100) / Total_votos;
                    this.charporcentaje.Series["Porcentaje de votos"].Points.AddXY(ListaCandidato[i].Nombre + " " + string.Format("{0:0.00}", porcentaje), porcentaje);
                }
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
