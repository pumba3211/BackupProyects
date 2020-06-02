using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParqueo.Logica.SQL
{
    public interface IClienteSQL
    {
        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        void InsertatCliente(int cedula, string nombre_completo, DateTime fecha_nacimiento, DateTime fecha_ingreso);
        void ModificarCliente(int cedula, string nombre_completo, DateTime fecha_nacimiento, DateTime fecha_ingreso);
        void EliminarCliente(int Cedula);
        DataSet CargarClientes(string filtro);
        DataSet ObtenerCliente(int cedula);
        Boolean ClienteRepetido(int Cedula);
    }
}
