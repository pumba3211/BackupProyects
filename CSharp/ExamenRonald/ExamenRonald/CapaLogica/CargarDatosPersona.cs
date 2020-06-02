using ExamenRonald.Estructura;
using ExamenRonald.UsoArchivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRonald.CapaLogica
{
    public class CargarDatosPersona
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
        public string ruta { set; get; }
        public List<Persona> ObtenerPersonas()
        {
            List<Persona> PersonaLista = new List<Persona>();
            IMetodosArchivos UsoPersonas = new MetodosArchivos();
            UsoPersonas.Ruta = ruta;

            StringBuilder informacion = new StringBuilder(UsoPersonas.leer()); //Se obtiene una lista de todos los repuestos 
            string[] lineas = informacion.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (lineas.Any())
            {
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] atributos = linea.Split(new string[] { "," }, StringSplitOptions.None);
                        PersonaLista.Add(new Persona()
                        {
                            Cedula = atributos[0],
                            NombreCompleto = atributos[5] + " " + atributos[6] + " " + atributos[7],
                            Sexo = Convert.ToInt32(atributos[2]),
                            Codelec = atributos[1]
                        });
                    }
                }
            }
            if (UsoPersonas.Is_Error)
            {
                this.Is_Error = true;
                this.ErrorDescripcion = UsoPersonas.ErrorDescripcion;
            }
            return PersonaLista;
        }
    }
}
