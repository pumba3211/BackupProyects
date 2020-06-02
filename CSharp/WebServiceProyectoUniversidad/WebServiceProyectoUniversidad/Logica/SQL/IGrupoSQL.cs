using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface IGrupoSQL
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertarGrupo(int id_carrera, int id_profesor, int id_aula);
        void ModificarGrupo(int id_grupo,int id_carrera, int id_profesor, int id_aula);
        void EliminarGrupo(int id_grupo);
        DataSet CargarGrupos(string filtro);
        DataSet ObtenerGrupo(int id_grupo);
        Boolean GrupoRepetido(int id_grupo);
    }
}