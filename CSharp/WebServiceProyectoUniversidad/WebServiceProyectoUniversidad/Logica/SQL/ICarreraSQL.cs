using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface ICarreraSQL
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertarCarrera(int id_carrera, string nombre_carrera, int estado);
        void ModificarCarrera(int id_carrera, string nombre_carrera, int estado);
        void EliminarCarrera(int id_carrera);
        DataSet CargarCarreras(string filtro);
        DataSet ObtenerCarrera(int id_carrera);
        Boolean CarrraRepetida(int id_carrera);
    }
}
