using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface IProfesorSQL
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarProfesor(int ID_Carrera,int Cedula);
        void ModificarProfesor(int ID_Profesor, int ID_Carrera, int Cedula);
        void EliminarProfesor(int ID_Profesor);
        DataSet CargarProfesor(string filtro);
        Boolean ProfesorRepetido(int ID_Profesor);
        DataSet ObtenerProfesor(int ID_Profesor);
        #endregion
    }
}