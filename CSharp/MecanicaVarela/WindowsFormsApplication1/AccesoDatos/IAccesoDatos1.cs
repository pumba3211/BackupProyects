using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaVarela.AccesoDatos
{
    public interface IAccesoDatos1
    {
        void Conectar();
        void Escribir(string hilera);
        string leer();
        void Editar(string id, string modificar);
        void Eliminar(string id);
        bool Is_Error{set;get;}
        string ErrorDescripcion{set;get;}
          
    }
}
