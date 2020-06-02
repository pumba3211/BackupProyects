using ExamenRonald.Estructura;
using ExamenRonald.UsoArchivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRonald.CapaLogica
{
    public class CargarDatosCodigoElectoral
    {
        public string ruta { set; get; }
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
        public List<CodigoElectoral> ObtenerCodigoElectoral()
        {
            List<CodigoElectoral> CodigosLista = new List<CodigoElectoral>();
            IMetodosArchivos UsoCodigos = new MetodosArchivos();
            UsoCodigos.Ruta = ruta;
            StringBuilder informacion = new StringBuilder(UsoCodigos.leer()); //Se obtiene una lista de todos los repuestos 
            string[] lineas = informacion.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (lineas.Any())
            {
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] atributos = linea.Split(new string[] { "," }, StringSplitOptions.None);
                        CodigosLista.Add(new CodigoElectoral()
                        {
                            Codele = atributos[0],
                            Provincia = atributos[1],
                            Canton = atributos[2],
                            Distrito = atributos[3],
                        });
                    }

                }
            }
            if (UsoCodigos.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoCodigos.ErrorDescripcion;
            }
            return CodigosLista;
        }
    }
}
