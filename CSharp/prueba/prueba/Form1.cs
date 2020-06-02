using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            crearventana();
            
        }
        public void crearventana()
        {
            System.Timers.Timer er = new System.Timers.Timer();
            er.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            er.Interval = 500;
            er.Enabled = true;
            
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {

            Form1 asd = new Form1();
            asd.Show();
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            Form1 asd = new Form1();
            asd.ShowInTaskbar = false;
            asd.ControlBox = false;
            asd.Show();
        }
        

    }
}
