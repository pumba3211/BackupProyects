using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenParqueo.Logica.Metodos
{
    public class FacturaCl
    {
        public SQL.IFacturaSQL ObtenerInstancia()
        {
            SQL.IFacturaSQL Facturasql = new Logica.Postgress.FacturaPostgress();
            return Facturasql;
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
        public void InsertarFactura(string matricula, DateTime Fecha_Ingreso, DateTime Fecha_Salida, double costo_hora)
        {
            SQL.IFacturaSQL Facturasql = this.ObtenerInstancia();
            Facturasql.InsertarFactura(matricula, Fecha_Ingreso, Fecha_Salida, costo_hora);
            if (Facturasql.IsError)
            {
                this.IsError = Facturasql.IsError;
                this.ErrorDescripcion = Facturasql.ErrorDescripcion;
            }
        }
        public void ModificarFactura(string matricula, DateTime Fecha_Ingreso, DateTime Fecha_Salida, double costo_hora, int N_Factura)
        {
            SQL.IFacturaSQL Facturasql = this.ObtenerInstancia();
            Facturasql.ModificarFactura(matricula, Fecha_Ingreso, Fecha_Salida, costo_hora, N_Factura);
            if (Facturasql.IsError)
            {
                this.IsError = Facturasql.IsError;
                this.ErrorDescripcion = Facturasql.ErrorDescripcion;
            }
        }
        public void EliminarFactura(int N_Factura)
        {
            SQL.IFacturaSQL Facturasql = this.ObtenerInstancia();
            Facturasql.EliminarFactura(N_Factura);
            if (Facturasql.IsError)
            {
                this.IsError = Facturasql.IsError;
                this.ErrorDescripcion = Facturasql.ErrorDescripcion;
            }
        }
        public System.Data.DataSet CargarFacturas(string filtro)
        {
            SQL.IFacturaSQL Facturasql = this.ObtenerInstancia();
            DataSet datos = Facturasql.CargarFacturas(filtro);
            if (Facturasql.IsError)
            {
                this.IsError = Facturasql.IsError;
                this.ErrorDescripcion = Facturasql.ErrorDescripcion;
            }
            return datos;
        }
        public System.Data.DataSet ObtenerFactura(int N_Factura)
        {
            SQL.IFacturaSQL Facturasql = this.ObtenerInstancia();
            DataSet datos = Facturasql.ObtenerFactura(N_Factura);
            if (Facturasql.IsError)
            {
                this.IsError = Facturasql.IsError;
                this.ErrorDescripcion = Facturasql.ErrorDescripcion;
            }
            return datos;
        }
        public bool FacturaExiste(int N_Factura)
        {
            SQL.IFacturaSQL Facturasql = this.ObtenerInstancia();
            bool esta = Facturasql.FacturaExiste(N_Factura);
            if (Facturasql.IsError)
            {
                this.IsError = Facturasql.IsError;
                this.ErrorDescripcion = Facturasql.ErrorDescripcion;
            }
            return esta;
        }
        public double CalculaCosto(int N_Factura)
        {
            SQL.IFacturaSQL Facturasql = this.ObtenerInstancia();
            double Total = Facturasql.CalculaCosto(N_Factura);
            if (Facturasql.IsError)
            {
                this.IsError = Facturasql.IsError;
                this.ErrorDescripcion = Facturasql.ErrorDescripcion;
            }
            return Total;
        }
    }
}