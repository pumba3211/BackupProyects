using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWPF.Logica
{
    public interface IPersonasSQL
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarPersona(int cedula,String Nombre,string apellido);
        void EditarPersona(int cedula, String Nombre, string apellido);
        void EliminarPersona(int cedula);
        DataSet TraerPersonas(string filtro);

        #endregion
    }
}

    

