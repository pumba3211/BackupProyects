using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.Vista
{
    public partial class frmAdministrativos : Form
    {
        public frmAdministrativos()
        {
            InitializeComponent();
        }
        private static readonly Lazy<AdministrativoService.Adminstrador> Administrador = new Lazy<AdministrativoService.Adminstrador>(() => new AdministrativoService.Adminstrador());
        public static AdministrativoService.Adminstrador administrador
        {
            get
            {
                return Administrador.Value;
            }
        }
    }
}
