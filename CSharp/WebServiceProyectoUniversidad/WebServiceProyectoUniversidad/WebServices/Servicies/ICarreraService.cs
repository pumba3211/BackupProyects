using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICarreraService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICarreraService
    {
        [OperationContract]
        string InsertarCarrera(Estructuras.Carrera carrera,Estructuras.Adminstrador administrador);

        [OperationContract]
        string ModificarCarrera(Estructuras.Carrera carrera, Estructuras.Adminstrador administrador);

        [OperationContract]
        string EliminarCarrera(int id_carrera, Estructuras.Adminstrador administrador);

        [OperationContract]
        IEnumerable<Estructuras.Carrera> TraerCarreras(string filtro);

        [OperationContract]
        Estructuras.Carrera ObtenerCarrera(int id_ciudad);
    }
}
