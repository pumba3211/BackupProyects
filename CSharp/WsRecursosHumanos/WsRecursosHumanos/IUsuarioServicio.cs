using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WsRecursosHumanos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarioServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarioServicio
    {
        [OperationContract]
        void DoWork();
    }
}
