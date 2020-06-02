using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAdministrativosService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAdministrativosService
    {
        [OperationContract]
        string DoWork();

        [OperationContract]
        string InsertarAdministrador(Estructuras.Persona persona,Estructuras.Adminstrador administrador);

        [OperationContract]
        string CambiarClave(string Username, string ContraseñaActual, string NuevaContraseña, string RepetirContraseña);

        [OperationContract]
        string CambiarPropietario(string username, int cedula);

        [OperationContract]
        string EliminarAdministrador(string username);

        [OperationContract]
        IEnumerable<Estructuras.Administrador_Persona> TraerAdministradores(string filtro);

        [OperationContract]
        Estructuras.Administrador_Persona ObtenerAdministrador(string username);

        [OperationContract]
        bool ValidarSesion(string username,string password);
    }
}
