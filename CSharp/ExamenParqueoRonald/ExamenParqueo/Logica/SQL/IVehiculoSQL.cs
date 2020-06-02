using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParqueo.Logica.SQL
{
    public interface IVehiculoSQL
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertatVehiculo(string matricula,int Cedula, String color,string marca);
        void ModificarVehiculo(string matricula, int Cedula, String color, string marca);
        void EliminarVehiculo(string matricula);
        DataSet CargarVehiculos(string filtro);
        DataSet ObtenerVehicul(string matricula);
        Boolean VehiculoRepetido(string matricula);
    }
}
