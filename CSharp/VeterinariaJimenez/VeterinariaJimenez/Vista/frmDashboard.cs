using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaJimenez.Vista
{
    public partial class frmDashboard : Form
    {
       

        public frmDashboard()
        {
          
            InitializeComponent();
        }

        private void animalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnimales oFrmAnimales = new frmAnimales();
            oFrmAnimales.ShowDialog();
        }
    }
}
