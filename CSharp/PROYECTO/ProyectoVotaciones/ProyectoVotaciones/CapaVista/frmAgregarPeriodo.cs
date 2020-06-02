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

namespace ProyectoVotaciones.CapaVista
{
    public partial class frmAgregarPeriodo : Form
    {
        MetodosPeriodos Periodo;
        List<Periodo> Periodos;
        public frmAgregarPeriodo()
        {
            InitializeComponent();
            Periodo = new MetodosPeriodos();
            Periodos = Periodo.ObtenerPeriodos();
        }

        private void botonAgregarVotante_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" || textAñoI.Text == "" || textAñoF.Text == "" || comboBoxUso.SelectedIndex.Equals(-1))//Se comprueba si todos los componentes tienen alguna informacion
            {
                MessageBox.Show("Ingresa Todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!System.IO.File.Exists(UrlArchivos.Periodo))//Se comprueba si el archivo existe, si no existe
                //simplemente se crea y se le asignan los datos
                {
                    Periodo.AgregarPeriodo(textID.Text, textAñoI.Text, textAñoF.Text, comboBoxUso.Text);
                    this.Close();
                }
                else
                {
                    bool HayPeriodo = false;
                    bool IDesta = false;
                    for (int i = 0; i < Periodos.Count; i++)
                    {
                        if (Periodos[i].Uso == "Si")//Comprobamos dsi ya hay un periodo en uso
                        {
                            HayPeriodo = true;
                            break;
                        }
                    }
                    for (int i = 0; i < Periodos.Count; i++)
                    {
                        if (Periodos[i].ID == textID.Text)//Se comprueba si ya hay un periodo con ese identificaror
                        {
                            IDesta = true;
                            break;
                        }
                    }
                    if (HayPeriodo == true)
                    {
                        MessageBox.Show("Ya hay un periodo registrado activo solo se puede tener uno,Modifica el Periodo actual activo a No", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (IDesta == true)
                    {
                        MessageBox.Show("Ese ID ya esta registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Periodo.AgregarPeriodo(textID.Text, textAñoI.Text, textAñoF.Text, comboBoxUso.Text);
                        this.Close();
                        Periodos = Periodo.ObtenerPeriodos();
                    }

                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
