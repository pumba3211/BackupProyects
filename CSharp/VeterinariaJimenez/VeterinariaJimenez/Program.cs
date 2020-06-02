using System;
using System.Windows.Forms;
using VeterinariaJimenez.Vista;

namespace VeterinariaJimenez
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
            AccesoDatos.AccesoDatos accesoDatos = AccesoDatos.AccesoDatos.Instance;
         
            
           Application.Run(new frmDashboard());
        }
    }
}
