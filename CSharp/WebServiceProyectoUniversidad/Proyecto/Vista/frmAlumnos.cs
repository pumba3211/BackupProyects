using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.Vista
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            CargarDatos();
        }
       EstudianteSerivice.EstudianteServiceClient wEstudiante = new EstudianteSerivice.EstudianteServiceClient();

       private void btnAgregar_Click(object sender, EventArgs e)
       {
           if (textDireccion.Text == "" || textDireccion.Text == " " || textApellidos.Text=="" || textApellidos.Text==" "|| txtCarrera.Text=="" || 
               txtCarrera.Text==" " || txtCedula.Text=="" || txtCedula.Text==" "||txtNombreCompleto.Text=="" || txtNombreCompleto.Text==" ")
           {
               MessageBox.Show("Por favor ingresa todos los Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else 
           {
               EstudianteSerivice.Adminstrador Administrador = new EstudianteSerivice.Adminstrador();
               EstudianteSerivice.Persona Persona = new EstudianteSerivice.Persona();
               EstudianteSerivice.Estudiante Estudiante = new EstudianteSerivice.Estudiante();

               Persona.Cedula = Convert.ToInt32(txtCedula.Text);
               Persona.Nombre = txtNombreCompleto.Text;
               Persona.Apellidos = textApellidos.Text;

               Estudiante.ID_Carrera = Convert.ToInt32(txtCarrera.Text);
               Estudiante.Fecha_nacimiento = dateTimePicker1.Value;
               Estudiante.Direccion = textDireccion.Text;

               Administrador.Username = Vista.frmAdministrativos.administrador.Username;
               Administrador.password = Vista.frmAdministrativos.administrador.password;

               string mensaje = "";
               mensaje = wEstudiante.InsertarEstudiante(Persona, Estudiante, Administrador);
  
               MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
               CargarDatos();
           }
       }
       private void label2_Click(object sender, EventArgs e)
       {

       }
       public void CargarDatos()
       {
           dtaAlumnos.DataSource = wEstudiante.TraerEstudiantes(null);
       }
    }
}
