using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGrupoServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGrupoServicio
    {
        [OperationContract]
        string InsertarGrupo(Estructuras.Grupo Grupo,Estructuras.Adminstrador Administrador);

        [OperationContract]
        string Modificargrupo(Estructuras.Grupo Grupo, Estructuras.Adminstrador Administrador);

        [OperationContract]
        string EliminarGrupo(int id_grupo, Estructuras.Adminstrador Administrador);

        [OperationContract]
        IEnumerable<Estructuras.Grupo_Entero> CargarGrupos(string filtro);

        [OperationContract]
        Estructuras.Grupo_Entero ObtenerGrupo (int id_grupo);
    }
}
