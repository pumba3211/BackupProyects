using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProyectoUniversidad.WebServices.Servicies
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAulaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAulaService
    {
        [OperationContract]
        string InsertarAula(string nombre,Estructuras.Adminstrador administrador);

        [OperationContract]
        string ModificarAula(Estructuras.Aula aula,Estructuras.Adminstrador administrador);

        [OperationContract]
        string EliminarAula(int ID_Aula, Estructuras.Adminstrador administrador);

        [OperationContract]
        IEnumerable<Estructuras.Aula> TraerAulas(string filtro);

        [OperationContract]
        Estructuras.Aula ObtenerAula(int ID_Aula);
    }
}
