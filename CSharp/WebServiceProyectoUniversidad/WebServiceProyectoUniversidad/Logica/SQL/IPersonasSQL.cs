using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProyectoUniversidad.Logica.SQL
{
    public interface IPersonasSQL
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarPersona(int cedula,string Nombre, string Apellidos);
        void ModificarPersona(int cedula, string Nombre, string Apellidos);
        void EliminarPersona(int cedula);
        DataSet CargarPersonas(string filtro);
        Boolean CedulaRepetida(int cedula);
        
        #endregion
    }
}
