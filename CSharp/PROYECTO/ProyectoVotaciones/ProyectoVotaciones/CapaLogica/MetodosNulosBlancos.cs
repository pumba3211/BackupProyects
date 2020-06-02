using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones.CapaLogica
{
    class MetodosNulosBlancos
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
        public string IDPeriodo { set; get; }//Se utiliza para enviar a la clase uso de archivos para crear el txt con el nombre del periodo seleccionado

        #region Metodos de Agregar,Editar
        /// <summary>
        /// Simplemente agremos al archivo Blanco y Nulos y su cantidad
        /// </summary>
        public void Agregar()
        {
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.IDPeriodo = IDPeriodo;
            UsoArchivos.VotanteOCandidato = 4;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Escribir("Blancos,0");
            UsoArchivos.Escribir("Nulos,0");
        }
        /// <summary>
        /// Se edita el archivo de nulos y blancos la cantidad de estos
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="CantVotos"></param>
        public void EditarNuloOBlanco(String ID, int CantVotos)
        {

            String hilera = ID + "," + CantVotos;
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.IDPeriodo = IDPeriodo;
            UsoArchivos.VotanteOCandidato = 4;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Editar(ID, hilera);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        #endregion

        #region Metodo Obtener Votos
        /// <summary>
        /// Simplemente se guarda la informacion del archivo txt y se guarda en una lista que luego se retorna
        /// </summary>
        /// <returns></returns>
        public List<NulosBlancos> ObtenerNulosOBlancos()
        {
            List<NulosBlancos> Lista = new List<NulosBlancos>();
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.IDPeriodo = IDPeriodo;
            UsoArchivos.VotanteOCandidato = 4;
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
                        Lista.Add(new NulosBlancos()
                        {
                            ID = atributos[0],
                            Votos = Convert.ToInt32(atributos[1])

                        });
                    }
                }
            }
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
            return Lista;
        }
        #endregion
    }
}
