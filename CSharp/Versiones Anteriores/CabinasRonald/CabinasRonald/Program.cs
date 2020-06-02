using CabinasRonald.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinasRonald
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conexion.AccederAlaConexion Acceso = Conexion.AccederAlaConexion.Instance;
            Conexion.AccederAlaConexion.Instance.Accesar.Estado();
            Application.Run(new Inicio());
        }
    }
}
