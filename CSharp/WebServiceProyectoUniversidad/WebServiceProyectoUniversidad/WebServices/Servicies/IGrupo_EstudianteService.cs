using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGrupo_EstudianteService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGrupo_EstudianteService
    {
        [OperationContract]
        string InsertarRegistro(Estructuras.Grupo_Estudiante grupo_estudiante, Estructuras.Adminstrador administrador);

        [OperationContract]
        string ModificarRegistro(Estructuras.Grupo_Estudiante grupo_estudiante, Estructuras.Adminstrador administrador);

        [OperationContract]
        string EliminarRegistro(int n_registro, Estructuras.Adminstrador administrador);

        [OperationContract]
        IEnumerable<Estructuras.Grupo_Estudiantes> EstudiantesGrupo(int id_grupo);
    }
}
