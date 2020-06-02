using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVotaciones.ManejoDeArchivos
{
    public static class UrlArchivos
    {

        public const String appPath = "C:\\Users\\Ronald\\Downloads\\New folder"; //"" + System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public const String DatosProyecto = appPath + "\\datosProyecto";

        public const String Periodo = DatosProyecto + "\\Periodo.txt";

        public const String Votantes = DatosProyecto + "\\Periodo.txt";

        public const String Candidatos = DatosProyecto + "\\Candidatos.txt";

        public const String NulosOBlancos = DatosProyecto + "\\Candidatos\\NulosOBlancos";

        public const String PeriodoCarpeta = DatosProyecto + "\\Periodo\\";

        public const String VotantesCarpeta = DatosProyecto + "\\Periodo\\";

        public const String CandidatosCarpeta = DatosProyecto + "\\Candidatos\\";
    }
}
