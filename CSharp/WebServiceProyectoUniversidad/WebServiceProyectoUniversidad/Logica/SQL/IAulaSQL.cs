using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface IAulaSQL
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertarAula(string nombre_aula);
        void ModificarAula(int ID_Aula, string nombre_aula);
        void EliminarAula(int ID_Aula);
        DataSet CargarAula(string filtro);
        DataSet ObtenerAula(int ID_Aula);
        Boolean AulaRepetida(int ID_Aula);
    }
}
