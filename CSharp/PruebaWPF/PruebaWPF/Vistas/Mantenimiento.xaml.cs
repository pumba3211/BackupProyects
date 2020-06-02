using PruebaWPF.Estructuras;
using PruebaWPF.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfPrueba
{
    /// <summary>
    /// Interaction logic for Mantenimiento.xaml
    /// </summary>
    public partial class Mantenimiento : Window
    {
        public Mantenimiento()
        {
            InitializeComponent();
            CargarDatos();
        }
        public void CargarDatos()
        {
            PersonasPost PersonaCl = new PersonasPost();
            List<Persona> Personas = new List<Persona>();
            Personas = PersonaCl.CargarPersonas();
            DataSet datos = PersonaCl.TraerPersonas("");
            if (PersonaCl.IsError)
            {
                MessageBox.Show(PersonaCl.ErrorDescripcion, "Error");
            }
            else
            {
                DatosPersonas.ItemsSource = Personas;
            }

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            PersonasPost PersonaCl = new PersonasPost();
            try
            {
                PersonaCl.InsertarPersona(Convert.ToInt32(Cedulatextt.Text), NombreText.Text, ApellidoText.Text);
            }
            catch (Exception eroor)
            {
                MessageBox.Show(eroor.Message, "Informacion");
            }
            Cedulatextt.Text = "";
            NombreText.Text = "";
            ApellidoText.Text = "";
            CargarDatos();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (DatosPersonas.Items.Count > 0)
            {
                Persona Persona = (Persona)DatosPersonas.SelectedItem;
                PersonasPost Personacl = new PersonasPost();
                Personacl.EliminarPersona(Persona.cedula);
                CargarDatos();
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            PersonasPost Personacl = new PersonasPost();
            Personacl.EditarPersona(Convert.ToInt32(Cedulatextt.Text), NombreText.Text, ApellidoText.Text);
            Cedulatextt.Text = "";
            NombreText.Text = "";
            ApellidoText.Text = "";
            CargarDatos();
        }

        private void Grid_PreviewMouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
           

        }

        private void DatosPersonas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = (DataGridRow)DatosPersonas.ItemContainerGenerator.ContainerFromIndex(0);
            var data = (Persona)row.Item;

            Cedulatextt.Text = "" + data.cedula;
            NombreText.Text = data.nombre;
            ApellidoText.Text = data.apellido;
        }

       
    }
}
