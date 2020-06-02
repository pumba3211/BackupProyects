using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WsRecursosHumanos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPlanilla" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPlanilla
    {
        [OperationContract]
        string AgregarPlanilla(Estructuras.Planilla planilla);

        [OperationContract]
        string EditarPlanilla(Estructuras.Planilla planilla, int id);

        [OperationContract]
        IEnumerable<Estructuras.Planilla> TraerPlanillas(string filtro);

        [OperationContract]
        Estructuras.Planilla ObtenerPlanilla(int id);

        [OperationContract]
        string InsertarPlanillaEmpleado(IEnumerable<Estructuras.PlanillaEmpleado> planillaempleado);

        
    }
}
