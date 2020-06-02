using ExamenRonald.CapaLogica;
using ExamenRonald.CapaLogica.SQLSERVER;
using ExamenRonald.Estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRonald
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarCodigoElectoral_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            
            File.ShowDialog();
            String ruta = File.FileName;
            if (ruta == "")
            {
                MessageBox.Show("No selecciono ninguna Ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                System.IO.StreamReader file = new System.IO.StreamReader(ruta);
                string linea = file.ReadLine();
                int cont = 0;
                for (int i = 0; i < linea.Length; i++)
                {
                    if(linea[i].Equals(','))
                    {
                        cont++;
                    }
                }
                if (cont == 3)
                {
                    CargarDatosCodigoElectoral Listas = new CargarDatosCodigoElectoral();
                    Listas.ruta=ruta;
                    List <CodigoElectoral>  ListaCodigos = Listas.ObtenerCodigoElectoral();
                    SQLserverCodigoElectoral codigo = new SQLserverCodigoElectoral();
                    for (int i = 0; i < ListaCodigos.Count; i++)
                    {
                        try
                        {
                            codigo.InsertarCodigo(ListaCodigos[i].Codele, ListaCodigos[i].Provincia, ListaCodigos[i].Canton, ListaCodigos[i].Distrito);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Archivo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void CargarPersona_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            
            File.ShowDialog();
            String ruta = File.FileName;
            if (ruta == "")
            {
                MessageBox.Show("No selecciono ninguna Ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                System.IO.StreamReader file = new System.IO.StreamReader(ruta);
                string linea = file.ReadLine();
                int cont = 0;
                for (int i = 0; i < linea.Length; i++)
                {
                    if(linea[i].Equals(','))
                    {
                        cont++;
                    }
                }
                if (cont == 7)
                {
                    CargarDatosPersona Listas = new CargarDatosPersona();
                    Listas.ruta=ruta;
                    List <Persona>  ListaPersonas = Listas.ObtenerPersonas();
                    SQLServerPersona Persona=new SQLServerPersona();
                    for (int i = 0; i < ListaPersonas.Count; i++)
                    {
                        try
                        {
                            Persona.InsertarPersona(ListaPersonas[i].Cedula, ListaPersonas[i].NombreCompleto, ListaPersonas[i].Sexo, ListaPersonas[i].Codelec);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Archivo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        
        }
        
    }
}
