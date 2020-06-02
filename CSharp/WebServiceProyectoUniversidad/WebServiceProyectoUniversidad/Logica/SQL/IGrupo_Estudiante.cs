using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface IGrupo_Estudiante
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertarEstudianteGrupo(int id_grupo,int id_estudiante);
        void ModificarEstudianteGrupo(int registro,int id_grupo, int id_estudiante);
        void EliminarRegistro(int n_registro);
        DataSet CargarEstudiantesengrupo(int id_grupo);
        DataSet CargarRegistros(string filtro);
        bool ExisteRegistro(int registro);
        bool EstudianteEnGrupo(int id_grupo, int id_estudiante);
    }
}
