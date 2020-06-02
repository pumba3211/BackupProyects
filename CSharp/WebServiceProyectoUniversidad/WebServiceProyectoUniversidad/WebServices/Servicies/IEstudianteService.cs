using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEstudianteService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEstudianteService
    {
        [OperationContract]
        string InsertarEstudiante(Estructuras.Persona persona, Estructuras.Estudiante estudiante, Estructuras.Adminstrador administrador);

        [OperationContract]
        string ModificarEstudiante(Estructuras.Persona persona, Estructuras.Estudiante estudiante, Estructuras.Adminstrador administrador);

        [OperationContract]
        string ElminarEstudiante(int ID_Estudiante,Estructuras.Adminstrador administrador);

        [OperationContract]
        IEnumerable<Estructuras.EstudiantePerson> TraerEstudiantes(string filtro);

        [OperationContract]
        Estructuras.EstudiantePerson ObtenerEstudiante(int ID_Estudiante);
        
    }
}
