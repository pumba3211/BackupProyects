using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WsRecursosHumanos.Estructuras;

namespace WsRecursosHumanos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEmpleadoServicio
    {

        [OperationContract]
        string AgregarEmpleado(Empleado empleado);

        [OperationContract]
        string ModificarEmpleado(Empleado empleado);

        [OperationContract]
        string EliminarEmpleado(int id);

        [OperationContract]
        IEnumerable<Empleado> TraearEmpleados(string filtro);

        [OperationContract]
        double ObtenerTipoCambio();
    }
}