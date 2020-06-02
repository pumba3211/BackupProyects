using System;
using System.Data;
using ProyectoGPS.AccesoDatos;
using ProyectoGPS.Logica.Postgrest;
using ProyectoGPS.Logica.SQL;
using ProyectoGPS.Logica.SQLServer;

namespace ProyectoGPS.Logica
{
    public class VehiculosCL
    {
        public Boolean IsError { set; get; }
        public String ErrorDescripcion { set; get; }

        public IVehiculosSql ObtenerInstancia()
        {
            IVehiculosSql vehiculosSql = null;
            IVehiculosSql vehiculosPostgresql = null;
            vehiculosSql = new VehiculosSQLServer();
            vehiculosPostgresql = new VehiculosPostgres();
              

            return vehiculosSql;
        }


        public void InsertarVehiculo(string matricula, string marca)
        {
            IVehiculosSql vehiculoSql = this.ObtenerInstancia();
            vehiculoSql.InsertarVehiculo(matricula,marca);
            if (vehiculoSql.IsError)
            {
                this.IsError = vehiculoSql.IsError;
                this.ErrorDescripcion = vehiculoSql.ErrorDescripcion;
            }
        }

        public DataSet TraerVehiculo(string filtro)
        {
            IVehiculosSql vehiculoSql = this.ObtenerInstancia();
            DataSet datos = vehiculoSql.TraerVehiculos(filtro);
            if (vehiculoSql.IsError)
            {
                this.IsError = vehiculoSql.IsError;
                this.ErrorDescripcion = vehiculoSql.ErrorDescripcion;
            }
            return datos;
        }

        public void EditarVehiculo(string matricula, string marca, string auxiliar)
        {
            IVehiculosSql vehiculosSql = this.ObtenerInstancia();
            vehiculosSql.EditarVehiculo(matricula,marca,auxiliar);
            if (vehiculosSql.IsError)
            {
                this.IsError = vehiculosSql.IsError;
                this.ErrorDescripcion = vehiculosSql.ErrorDescripcion;
            }
        }


        public void EliminarVehiculo(string matricula)
        {
            IVehiculosSql VehiculosSql = this.ObtenerInstancia();
            VehiculosSql.EliminarVehiculo(matricula);
            if (VehiculosSql.IsError)
            {
                this.IsError = VehiculosSql.IsError;
                this.ErrorDescripcion = VehiculosSql.ErrorDescripcion;
            }
        }

    }
}
