using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExamenParqueo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioWeb
    {
        [OperationContract]
        string Conexion();

        [OperationContract]
        string InsertarCliente(Estructuras.Cliente Cliente);

        [OperationContract]
        string ModificarCliente(Estructuras.Cliente Cliente);

        [OperationContract]
        string EliminarCliente(int Cedula);

        [OperationContract]
        IEnumerable<Estructuras.Cliente> CargarClientes(string filtro);

        [OperationContract]
        Estructuras.Cliente ObtenerCliente(int Cedula);

        [OperationContract]
        string InsertarVehiculo(Estructuras.Vehiculo Vehiculo);

        [OperationContract]
        string ModificarVehiculo(Estructuras.Vehiculo Vehiculo);

        [OperationContract]
        string ElimianrVehiculo(string matricula);

        [OperationContract]
        IEnumerable<Estructuras.Vehiculo> Cargarvehiculos(string filtro);

        [OperationContract]
        Estructuras.Vehiculo ObtenerVehiculo(string matricula);

        [OperationContract]
        string InsertarFactura(Estructuras.Factura Factura);

        [OperationContract]
        string ModificarFactura(Estructuras.Factura Factura);

        [OperationContract]
        string EliminarFactura(int Numero_Factura);

        [OperationContract]
        IEnumerable<Estructuras.Factura> CargarFacturas(string filtro);

        [OperationContract]
        Estructuras.Factura ObtenerFactura(int Numero_Factura);

        [OperationContract]
        string CalcularCostoFactura(int Numero_Factura);
    }
}
