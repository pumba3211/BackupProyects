using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface IEstudianteSQL
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertarEstudiante(DateTime fecha_nacimiento,int id_carrera,int cedula,string direccion);
        void ModificarEstudiante(int id_estudiante, DateTime fecha_nacimiento, int id_carrera, int cedula, string direccion);
        void EliminarEstudiante(int id_estudiante);
        DataSet CargarEstudiantes(string filtro);
        DataSet ObtenerEstudiante(int id_estudiante);
        Boolean EstudianteRepetido(int id_estudiante);
    }
}
