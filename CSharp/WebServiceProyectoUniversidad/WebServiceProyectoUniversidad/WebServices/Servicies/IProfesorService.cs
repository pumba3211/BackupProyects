using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProfesorService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProfesorService
    {
        [OperationContract]
        string InsertarProfesor(Estructuras.Persona persona, Estructuras.Profesor Profesor, Estructuras.Adminstrador administrador);

        [OperationContract]
        string ModificarProfesor(Estructuras.Persona persona, Estructuras.Profesor Profesor, Estructuras.Adminstrador administrador);

        [OperationContract]
        string EliminarProfesor(int ID_Profesor, Estructuras.Adminstrador administrador);

        [OperationContract]
        IEnumerable<Estructuras.ProfesorPersona> TraerProfesores(string filtro);

        [OperationContract]
        Estructuras.ProfesorPersona ObtenerProfesor(int ID_Profesor);
    }
}
