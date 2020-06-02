using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoVotaciones.Estructura;
using ProyectoVotaciones.ManejoDeArchivos;

namespace ProyectoVotaciones.CapaLogica
{
    class MetodosPeriodos
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

        #region Metodos Agregat,Eliminar,Editar
        /// <summary>
        /// Se Agrega un periodo en el archivo y ruta seleccionado en la clase uso de archivos
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="AñoInicio"></param>
        /// <param name="AñoFinal"></param>
        /// <param name="Uso"></param>
        public void AgregarPeriodo(String ID, String AñoInicio, String AñoFinal, String Uso)
        {
            String hilera = ID + "," + AñoInicio + "," + AñoFinal + "," + Uso;
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 3;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Escribir(hilera);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        /// <summary>
        /// Se elimina un periodo identificado por la id de este
        /// </summary>
        /// <param name="id"></param>
        public void EliminarPeriodo(string id)
        {
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 3;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Eliminar(id);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        /// <summary>
        /// Se edita el periodo igualmente identificado por el id mas los datos que se quieren modificar
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="AñoInicio"></param>
        /// <param name="AñoFinal"></param>
        /// <param name="Uso"></param>
        public void EditarPeriodo(String ID, String AñoInicio, String AñoFinal, String Uso)
        {

            String hilera = ID + "," + AñoInicio + "," + AñoFinal + "," + Uso;
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 3;
            UsoArchivos.SetRutaAUsar();
            UsoArchivos.Editar(ID, hilera);
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
        }
        #endregion

        #region Metodo Obtener Datos Periodos
        /// <summary>
        /// Se obtienen los datos del archivo de texto de periodos en la ruta
        /// </summary>
        /// <returns></returns>
        public List<Periodo> ObtenerPeriodos()
        {
            List<Periodo> PeriodosLista = new List<Periodo>();
            IintefazDeArchivos UsoArchivos = new UsoArchivos();
            UsoArchivos.VotanteOCandidato = 3;
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
                        PeriodosLista.Add(new Periodo()
                        {
                            ID = atributos[0],
                            AñoInicio = atributos[1],
                            AñoFinal = atributos[2],
                            Uso = atributos[3]
                        });
                    }
                }
            }
            if (UsoArchivos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoArchivos.ErrorDescripcion;
            }
            return PeriodosLista;
        }
        #endregion
    }
}
