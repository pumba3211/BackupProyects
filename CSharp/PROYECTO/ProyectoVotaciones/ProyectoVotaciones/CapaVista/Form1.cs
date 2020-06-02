using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoVotaciones.ManejoDeArchivos;
using ProyectoVotaciones.CapaLogica;
using System.Collections;
using ProyectoVotaciones.Estructura;

namespace ProyectoVotaciones
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
            textUsuario.Text = "admin";//Nombre de usuario administrador prederteminado
            textClave.Text = "12345";//Claver de usuario administrador prederteminado
            TextBox asd = new TextBox();
            asd.Show();
        }

        #region Metodo para Ppoder ingresar

        public void Ingresar()
        {
            if (textUsuario.Text == "admin" && textClave.Text == "12345")
            {
                MessageBox.Show("Has ingresado como usuario maestro", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDashboard VentanaMenu = new frmDashboard();//Muesta el menu donde estan todos los precesos
                VentanaMenu.Show();
                textClave.Text = "";
                textUsuario.Text = "";
            }
            else
            {
                if (!File.Exists(Application.StartupPath + "/datosProyecto/Votantes/Votantes.txt"))
                {
                    MessageBox.Show("No se ha ingresado ningun usuario aun", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textClave.Text = "";
                    textUsuario.Text = "";
                }
                else
                {
                    MetodosVotantes Usuarios = new MetodosVotantes();
                    List<Votante> ListaUsuarios = Usuarios.ObtenerVotantes();
                    bool esta = false;//Se usa para consultar luego si el usuario existe en la lista
                    for (int i = 0; i < ListaUsuarios.Count; i++)
                    {
                        if (ListaUsuarios[i].Cedula == textUsuario.Text && ListaUsuarios[i].Contraseña == textClave.Text)//Consulta si en la posicion de la lista la clave y nombre de usuario son iguales
                        {
                            if (ListaUsuarios[i].Tipo == "Administrador")
                            {
                                frmDashboard FormMenu = new frmDashboard(); ;
                                if (ListaUsuarios[i].ComprobarVoto == "Si")//Se comprueba si el administracion ya voto de ser asi el menu emitir voto no estara disponible para el
                                {
                                    FormMenu.ComprobarAdmistradorVoto = false;
                                }
                                else
                                {
                                    FormMenu.ComprobarAdmistradorVoto = true;
                                }
                                textClave.Text = "";
                                esta = true;
                                textUsuario.Text = "";
                                FormMenu.CedAdmin = textUsuario.Text;
                                FormMenu.Show();
                                break;
                            }
                            else
                            {
                                if (ListaUsuarios[i].ComprobarVoto == "Si")//comprueba si ya voto, si ya ha votado muestra el mensaje
                                {
                                    MessageBox.Show("Ya este Usuario ha votado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    esta = true;
                                    textClave.Text = "";
                                    textUsuario.Text = "";
                                }
                                else
                                {
                                    if (!File.Exists(UrlArchivos.Periodo) || !File.Exists(UrlArchivos.Candidatos))//Se comprueban si hay periodos o candidatos en el periodo si no hay
                                    //no se podra ingresar
                                    {
                                        MessageBox.Show("Lo sentimos aun no puedes votar hay problemas en el servidor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        esta = true;
                                    }
                                    else
                                    {
                                        MetodosPeriodos Periodos = new MetodosPeriodos();
                                        List<Periodo> Periodo = Periodos.ObtenerPeriodos();
                                        bool Hayperiodoactivo = false;
                                        string IDPeriodo = "";
                                        for (int j = 0; j < Periodo.Count; j++)
                                        {
                                            if (Periodo[j].Uso == "Si")//Se comprueba cual periodo esta en uso
                                            {
                                                Hayperiodoactivo = true;
                                                IDPeriodo = Periodo[j].ID;//Si hay periodo se le asigna a la variable la informacion de la lista en la que se encontro un si
                                                break;
                                            }
                                        }
                                        if (Hayperiodoactivo == true)
                                        {
                                            MessageBox.Show("Bienvenido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            frmEmitirVoto VentanaVoto = new frmEmitirVoto();
                                            VentanaVoto.CedulaVotante = textUsuario.Text; //Se utlizar para emviarle al form votar la cedula del votante 
                                            //para editarlo cuando voto
                                            esta = true;
                                            textClave.Text = "";
                                            textUsuario.Text = "";
                                            VentanaVoto.IDPeriodo = IDPeriodo;
                                            VentanaVoto.Show();
                                            break;

                                        }
                                        else
                                        {
                                            MessageBox.Show("No Hay Periodos Activos,o Candidatos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (esta == false)//Se comprueba a ver si no se encontro el votante
                    {
                        MessageBox.Show("El usuario no existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textClave.Text = "";
                        textUsuario.Text = "";
                    }
                }
            }
        }
        #endregion

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
