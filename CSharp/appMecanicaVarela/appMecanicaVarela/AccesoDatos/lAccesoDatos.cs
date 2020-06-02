using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appMecanicaVarela
{
    public interface lAccesoDatos
    {
        void Conectar();

        void Escribir(string hilera);

        string leer();

        void Editar(string id, string modificar);

        void Eliminar(string id);

        bool IsError { set; get;}

        string ErrorDescripcion{ set; get;}
    }
}
