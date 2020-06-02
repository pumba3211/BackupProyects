using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRonald.UsoArchivos
{
    public interface IMetodosArchivos
    {
        void Conectar();
        string leer();
        string Ruta { set; get; }
        bool Is_Error { set; get; }
        string ErrorDescripcion { set; get; }

    }
}
