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
using ProyectoVotaciones.Estructura;
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones
{
    public partial class frmEmitirVoto : Form
    {
        int posicion = 0;
        public string IDPeriodo { set; get; }//ID DEL PERIODO QUE SE VA USAR
        public string CedulaVotante { set; get; }//GUARDA LA CEDULA VOTANTE QUE SE VA A MODIFICAR A QUE YA HA VOTADO
        public frmEmitirVoto()
        {
            InitializeComponent();
        }

        private void frmEmitirVoto_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            MetodosCandidatos candidato = new MetodosCandidatos();
            List<Candidato> ListaCandidato = candidato.ObtenerCandidatos();
            string cedula = ListaCandidato[0].ID;
            for (int i = 0; i < ListaCandidato.Count; i++)
            {
                if (ListaCandidato[i].IDPeriodo == IDPeriodo)//Lo usamos apra cargar solo los candidatos del periodo que tenemos activo
                {
                    try
                    {
                        dtagridVoto.RowTemplate.Height = 70;
                        dtagridVoto.Rows.Add((System.Drawing.Image.FromFile(UrlArchivos.CandidatosCarpeta + ListaCandidato[i].ID + ".JPEG")), (System.Drawing.Image.FromFile(UrlArchivos.CandidatosCarpeta + "BANDERA" + ListaCandidato[i].ID + ".JPEG")), ListaCandidato[i].PartidoPolitico, ListaCandidato[i].Nombre, false);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                }
            }

        }

        public void Emitir_Voto(String id_Candidato)
        {

        }

        private void dtagridVoto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                posicion = e.RowIndex;
                MetodosCandidatos candidato = new MetodosCandidatos();
                List<Candidato> ListaCandidato = candidato.ObtenerCandidatos();
                Emitir_Voto(ListaCandidato[posicion].ID);
                dtagridVoto.Rows[posicion].Cells[4].Value = true;
                ptCandidato.Image = Image.FromFile(UrlArchivos.CandidatosCarpeta + ListaCandidato[posicion].ID + ".JPEG");
                LblNombreCandidato.Text = ListaCandidato[posicion].Nombre + " " + ListaCandidato[posicion].Apellidos;
                lblPartido.Text = ListaCandidato[posicion].PartidoPolitico;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BtonEmitirVoto_Click(object sender, EventArgs e)
        {
            MetodosCandidatos candidato = new MetodosCandidatos();
            List<Candidato> ListaCandidato = candidato.ObtenerCandidatos();
            MetodosVotantes Votantes = new MetodosVotantes();
            List<Votante> votante = Votantes.ObtenerVotantes();
            MetodosNulosBlancos NB = new MetodosNulosBlancos();
            NB.IDPeriodo = IDPeriodo;
            NB.Agregar();
            List<NulosBlancos> NBS = NB.ObtenerNulosOBlancos();
            int cont = 0;
            for (int i = 0; i < dtagridVoto.RowCount; i++)
            {
                bool estado = Convert.ToBoolean(dtagridVoto.Rows[i].Cells[4].Value);
                if (estado == true)
                {
                    cont++;//Contamos cuantos checkbocks estan en true
                }
            }
            if (cont == 1)//Consultamos si fue solo un checkbocks se comprueba cual posiciion era para saber que candidato hay que editar
            {
                for (int i = 0; i < dtagridVoto.RowCount; i++)
                {
                    bool estado = Convert.ToBoolean(dtagridVoto.Rows[i].Cells[4].Value);
                    if (estado == true)
                    {
                        candidato.EditarCandidato(ListaCandidato[i].ID, ListaCandidato[i].Nombre, ListaCandidato[i].Apellidos, ListaCandidato[i].PartidoPolitico,
                            Convert.ToInt32(ListaCandidato[i].Votos) + 1, ListaCandidato[i].IDPeriodo);
                        break;
                    }
                }


            }
            if (cont == 0)
            {
                NB.EditarNuloOBlanco(NBS[0].ID, Convert.ToInt32(NBS[0].Votos) + 1);//SE EDITAN LOS BALNCOS DEL PERIODO
            }
            else if (cont > 1)
            {
                NB.EditarNuloOBlanco(NBS[1].ID, Convert.ToInt32(NBS[0].Votos) + 1);//Se editan los nulos del periodo
            }
            for (int i = 0; i < votante.Count; i++)
            {
                if (votante[i].Cedula == CedulaVotante)//Se comprueba si son iguales para saber cual cambiar
                {
                    Votantes.EditarVotante(votante[i].Cedula, votante[i].Contraseña, votante[i].Tipo, votante[i].Nombre, votante[i].Apellido1, votante[i].Apellido2, "Si");
                    //Se edita el votante el estado a SI DE SI HA VOTADO
                    this.Close();
                    break;
                }
                else
                {
                }

            }

        }

        private void dtagridVoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void BtonAnular_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
