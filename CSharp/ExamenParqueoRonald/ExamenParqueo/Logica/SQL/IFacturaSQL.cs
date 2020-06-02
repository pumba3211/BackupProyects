using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParqueo.Logica.SQL
{
    public  interface IFacturaSQL
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertarFactura(string matricula, DateTime Fecha_Ingreso,DateTime Fecha_Salida,double costo_hora);
        void ModificarFactura(string matricula, DateTime Fecha_Ingreso, DateTime Fecha_Salida, double costo_hora,int N_Factura);
        void EliminarFactura(int N_Factura);
        DataSet CargarFacturas(string filtro);
        DataSet ObtenerFactura(int N_Factura);
        Boolean FacturaExiste(int N_Factura);
        double CalculaCosto(int N_Factura);
    }
}
