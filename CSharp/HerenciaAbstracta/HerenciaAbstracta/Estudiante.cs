using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAbstracta
{
    public class Estudiante:Persona
    {
       
        private int id;
        private string nombre;
        private string apellido1;
        private string apellido2;
        #region Metodos clase padre
        public override int SetId(int id)
        {
            this.id = id;
            return id;
        }

        public override string SetNombre(string nombre)
        {
            this.nombre = nombre;
            return nombre;
        }

        public override string SetApellido1(string apellido1)
        {
            this.apellido1 = apellido1;
            return apellido1;
        }

        public override string SetApellido2(string apellido2)
        {
            this.apellido2 = apellido2;
            return apellido2;
        }
        public override string ToString()
        {
            return "El id es " + id + " Nombre " + nombre + " " + apellido1 + " " + apellido2;
        }
        #endregion

        #region Metodos de la clase
        public int calificaciones { set; get; }
        public string notas { set; get; }
        #endregion
    }

}
