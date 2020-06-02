using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones.CapaLogica
{
    public class MetodosVotantes
    {
        public bool Is_Error
        {
            set;
            get;
        }

        public string ErrorDescripcion
        {
            set;
            get;
        }
        public String contraseña { set; get; }//Se utiliza para asignar la contraseña
        char[] caracteres = new char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
            ,'1','2','3','4','5','6','7','8','9','0'};//Se utiliza para recorrerlo y por medio de la posicion obtener el caracter que se necesita
        /// <summary>
        /// Se recorre el arreglo de caracteres 5 veces, en cada vuelta de ciclo se asigna a la contraseña  el caracterer de la posician del arreglo que ha salido aleatoria
        /// </summary>
        public void GenerarContraseña()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int NumeroDeCaracter = random.Next(0, 36);
                contraseña = contraseña + caracteres[NumeroDeCaracter];
            }
            MessageBox.Show("La contraseña suya es" + contraseña, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Metodos Agregar,Editar,Eliminar
        /// <summary>
        /// Se agregan todos los datos de un votante en un txt Votantes
        /// </summary>
        /// <param name="Cedula"></param>
        /// <param name="tipo"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellido1"></param>
        /// <param name="Apellido2"></param>
        /// <param name="Voto"></param>
        public void AgregarVotante(String Cedula, String tipo, String Nombre, String Apellido1, String Apellido2, String Voto)
        {
            String hilera = Cedula + "," + contraseña + "," + tipo + "," + Nombre + "," + Apellido1 + "," + Apellido2 + "," + Voto;
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 1;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Escribir(hilera);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        /// <summary>
        /// Se elimina un votante buscando por la id de este 
        /// </summary>
        /// <param name="id"></param>
        public void EliminarVotante(string id)
        {
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 1;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Eliminar(id);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        /// <summary>
        ///Editamos un votante del archivo de votantes.txt
        /// </summary>
        /// <param name="Cedula"></param>
        /// <param name="Contraseña"></param>
        /// <param name="tipo"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellido1"></param>
        /// <param name="Apellido2"></param>
        /// <param name="Voto"></param>
        public void EditarVotante(String Cedula, String Contraseña, String tipo, String Nombre, String Apellido1, String Apellido2, String Voto)
        {

            String hilera = Cedula + "," + Contraseña + "," + tipo + "," + Nombre + "," + Apellido1 + "," + Apellido2 + "," + Voto;
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 1;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Editar(Cedula, hilera);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        #endregion

        #region Metodo que obtiene los datos de Votantes
        /// <summary>
        /// Se utiliza para obtener toda la informacion de los votantes registrados
        /// </summary>
        /// <returns></returns>
        public List<Votante> ObtenerVotantes()
        {
            List<Votante> VotantesLista = new List<Votante>();
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 1;
            UsoArchivos.SetRutaAUsar();
            StringBuilder informacion = new StringBuilder(UsoArchivos.leer()); //Se obtiene una lista de todos los repuestos 
            string[] lineas = informacion.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (lineas.Any())
            {
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] atributos = linea.Split(new string[] { "," }, StringSplitOptions.None);
                        VotantesLista.Add(new Votante()
                        {
                            Cedula = atributos[0],
                            Contraseña = atributos[1],
                            Tipo = atributos[2],
                            Nombre = atributos[3],
                            Apellido1 = atributos[4],
                            Apellido2 = atributos[5],
                            ComprobarVoto = atributos[6]
                        });
                    }
                }
            }
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
            return VotantesLista;
        }
        #endregion

        #region Metodo que Borro la Foto del Votante
        public void BorrarFotoVotante(String Cedula)
        {
            String ruta = UrlArchivos.VotantesCarpeta + Cedula + ".JPEG";//Se utiliza para eliminar la foto del votante
            //buscandala por el nombre de esta que seria la cedula del votante
            try
            {
                if (!File.Exists(ruta))
                {

                }
                else
                {
                    File.Delete(ruta);
                }
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
        }
        #endregion
    }
}








