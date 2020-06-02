using System;
using System.Data;

namespace ProyectoGPS.Logica.SQL
{
    public interface IVehiculosSql
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarVehiculo(string matricula, string marca);
        void EditarVehiculo(string matricula, string marca);
        void EliminarVehiculo(string matricula);
        DataSet TraerVehiculos(string filtro);

        #endregion
    }
}
