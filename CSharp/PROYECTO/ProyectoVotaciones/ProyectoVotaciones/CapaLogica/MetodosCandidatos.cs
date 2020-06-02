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
    class MetodosCandidatos
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

        #region Metodos de Agregar,Eliminar y Modificar Candidatos
        /// <summary>
        ///Hace una agregacion de los atributos del candidato en el archivo Candidatos.txt
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="PartidoPolitico"></param>
        /// <param name="CantVotos"></param>
        /// <param name="IDPeriodo"></param>
        public void AgregarCandidato(String ID, String Nombre, String Apellidos, String PartidoPolitico, int CantVotos, string IDPeriodo)
        {
            String hilera = ID + "," + Nombre + "," + Apellidos + "," + PartidoPolitico + "," + CantVotos + "," + IDPeriodo;
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 2;
            UsoArchivos.SetRutaAUsar();//Asignamos la ruta a usar
            UsoArchivos.Escribir(hilera);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        /// <summary>
        ///Se selecciona una candidato en formemliminar candidatoo y por medio de este se manda el id de dicho candidato y se elimina
        /// </summary>
        /// <param name="id"></param>
        public void EliminarCandidato(string id)
        {
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 2;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Eliminar(id);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        /// <summary>
        /// Se EDITA EL CANDIDATO , buscando por el id de este en el txt y luego remplasandolo
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="PartidoPolitico"></param>
        /// <param name="CantVotos"></param>
        /// <param name="IDPeriodo"></param>
        public void EditarCandidato(String ID, String Nombre, String Apellidos, String PartidoPolitico, int CantVotos, string IDPeriodo)
        {

            String hilera = ID + "," + Nombre + "," + Apellidos + "," + PartidoPolitico + "," + CantVotos + "," + IDPeriodo;
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 2;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Editar(ID, hilera);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        #endregion


        #region Metodo que obtiene los datos de los candidatos
        /// <summary>
        ///Hace una lista tipo de la estructura Candidato y le asigna la estructura, del archivo Candidatos.txt
        /// </summary>
        /// <returns></returns>Retorna la Lista CandidatosLista
        public List<Candidato> ObtenerCandidatos()
        {
            List<Candidato> CandidatosLista = new List<Candidato>();
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 2;
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
                        CandidatosLista.Add(new Candidato()
                        {
                            IDPeriodo = atributos[5],
                            ID = atributos[0],
                            Nombre = atributos[1],
                            Apellidos = atributos[2],
                            PartidoPolitico = atributos[3],
                            Votos = Convert.ToInt32(atributos[4])

                        });
                    }
                }
            }
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
            return CandidatosLista;
        }
        #endregion


        #region Borra la foto del candidato y de la Bandera
        /// <summary>
        ///Se borra la foto del candidato por la cedula o id de este
        /// </summary>
        /// 
        /// <param name="Cedula"></param>
        public void BorrarFotoCandidato(String Cedula)
        {
            String ruta = UrlArchivos.CandidatosCarpeta + Cedula + ".JPEG";//La ruta donde se encuentra la imagen mas elnombre de esta
            try
            {
                if (!File.Exists(ruta))//Se Comprueba sil archivo no existe para que no haya errores a la hora de la ejecucion
                {

                }
                else
                {
                    File.Delete(ruta);//Si existe entonces se elimina por medio de la ruta enviada
                }
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
        }
        /// <summary>
        /// Se borra la bandera del candidato por la cedula o id de este, y utilizamos la misma logica del meto para borrar la foto del candidato
        /// </summary>
        /// <param name="Cedula"></param>
        public void BorrarBandera(String Cedula)
        {
            String ruta = UrlArchivos.CandidatosCarpeta + "BANDERA" + Cedula + ".JPEG";
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


