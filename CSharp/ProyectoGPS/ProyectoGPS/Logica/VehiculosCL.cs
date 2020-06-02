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
            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    vehiculosSql = new VehiculosSQLServer();
                    break;
                case ContextDataBase.PostgreSql:
                    vehiculosSql = new VehiculosPostgres();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return vehiculosSql;
        }


        public void InsertarVehiculo(string matricula, string marca)
        {
            IVehiculosSql vehiculoSql = this.ObtenerInstancia();
            vehiculoSql.InsertarVehiculo(matricula, marca);
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

        public void EditarVehiculo(string matricula, string marca)
        {
            IVehiculosSql vehiculosSql = this.ObtenerInstancia();
            vehiculosSql.EditarVehiculo(matricula, marca);
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
