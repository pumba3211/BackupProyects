using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaInterface
{
    public interface IPersona
    {
        void setID(int id);
        void setNombre(String Nombre);
        void setApellidos(String apellido);
        string Impresion();
    }
}
