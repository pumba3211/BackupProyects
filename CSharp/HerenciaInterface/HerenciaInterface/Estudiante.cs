using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaInterface
{
    public class Estudiante:IPersona
    {
        private int id;
        private String nombre;
        private string apellido;
        public void setID(int id)
        {
            this.id = id;
        }

        public void setNombre(string Nombre)
        {
            this.nombre = Nombre;
        }

        public void setApellidos(string apellido)
        {
            this.apellido = apellido;
        }

        public string Impresion()
        {
            return "EL ID ES " + id + " ,El nombre es: " + nombre + " " + apellido;
        }

        #region Metodos de la clase
        public int Calificaciones { set; get; }
        public String Notas { set; get; }
        #endregion 
    }
}
