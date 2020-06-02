using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenParqueo.Logica.Metodos
{
    public class VehiculoCl
    {
        public SQL.IVehiculoSQL ObtenerInstancia()
        {
            SQL.IVehiculoSQL Vehiculosql = new Logica.Postgress.VehiculoPostgress();
            return Vehiculosql;
        }
        public bool IsError
        {
            set;
            get;
        }

        public string ErrorDescripcion
        {
            set;
            get;
        }
        public void InsertatVehiculo(string matricula, int Cedula, string color, string marca)
        {
            SQL.IVehiculoSQL VehiculoSQL = this.ObtenerInstancia();
            VehiculoSQL.InsertatVehiculo(matricula, Cedula, color, marca);
            if (VehiculoSQL.IsError)
            {
                this.IsError = VehiculoSQL.IsError;
                this.ErrorDescripcion = VehiculoSQL.ErrorDescripcion;
            }
        }

        public void ModificarVehiculo(string matricula, int Cedula, string color, string marca)
        {
            SQL.IVehiculoSQL VehiculoSQL = this.ObtenerInstancia();
            VehiculoSQL.ModificarVehiculo(matricula, Cedula, color, marca);
            if (VehiculoSQL.IsError)
            {
                this.IsError = VehiculoSQL.IsError;
                this.ErrorDescripcion = VehiculoSQL.ErrorDescripcion;
            }
        }
        public void EliminarVehiculo(string matricula)
        {
            SQL.IVehiculoSQL VehiculoSQL = this.ObtenerInstancia();
            VehiculoSQL.EliminarVehiculo(matricula);
            if (VehiculoSQL.IsError)
            {
                this.IsError = VehiculoSQL.IsError;
                this.ErrorDescripcion = VehiculoSQL.ErrorDescripcion;
            }
        }
        public System.Data.DataSet CargarVehiculos(string filtro)
        {
            SQL.IVehiculoSQL VehiculoSQL = this.ObtenerInstancia();
            DataSet datos = VehiculoSQL.CargarVehiculos(filtro);
            if (VehiculoSQL.IsError)
            {
                this.IsError = VehiculoSQL.IsError;
                this.ErrorDescripcion = VehiculoSQL.ErrorDescripcion;
            }
            return datos;
        }
        public System.Data.DataSet ObtenerVehicul(string matricula)
        {
            SQL.IVehiculoSQL VehiculoSQL = this.ObtenerInstancia();
            DataSet datos = VehiculoSQL.ObtenerVehicul(matricula);
            if (VehiculoSQL.IsError)
            {
                this.IsError = VehiculoSQL.IsError;
                this.ErrorDescripcion = VehiculoSQL.ErrorDescripcion;
            }
            return datos;
        }
        public bool VehiculoRepetido(string matricula)
        {
            SQL.IVehiculoSQL VehiculoSQL = this.ObtenerInstancia();
            bool esta = VehiculoSQL.VehiculoRepetido(matricula);
            if (VehiculoSQL.IsError)
            {
                this.IsError = VehiculoSQL.IsError;
                this.ErrorDescripcion = VehiculoSQL.ErrorDescripcion;
            }
            return esta;
        }
    }
}