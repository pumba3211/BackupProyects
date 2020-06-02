using System;
using System.Data;

namespace WsRecursosHumanos.Logica.SQL
{
    public interface IEmpleadoSql
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarEmpleado(int cedula, string nombre, int edad, string puesto);
        void EditarEmpleado(int id, int cedula, string nombre, int edad, string puesto);
        void EliminarEmpleado(int id);
        DataSet TraerEmpleados(string filtro);

        #endregion
    }
}
