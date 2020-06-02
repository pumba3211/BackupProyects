using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAbstracta
{
   public abstract class Persona
    {
        public abstract int SetId(int id);
        public abstract string SetNombre(string nombre);
        public abstract string SetApellido1(string apellido1);
        public abstract string SetApellido2(string apellido2);
        public abstract string ToString();
   }
}
