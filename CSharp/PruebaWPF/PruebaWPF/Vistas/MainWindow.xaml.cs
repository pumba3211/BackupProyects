
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPrueba;

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Usuario.Text = "wpf";
            Contraseña.Text = "12345";
            Ingresar.Background = Brushes.Red;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("" + AccesoDatos.AccesoDatos.Instance.accesodatos.Estado(), "12");
            if (ConfigurationManager.AppSettings["Usuario"].Equals(Usuario.Text) &&
                       ConfigurationManager.AppSettings["Password"].Equals(Contraseña.Text))
            {
                Mantenimiento Mantenimientos = new Mantenimiento();
                Mantenimientos.Show();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el usuario", "Info");
            }
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Ingresar.Background = Brushes.Black;
        }

        private void Ingresar_MouseLeave(object sender, MouseEventArgs e)
        {
            Ingresar.Background = Brushes.Red;
        }

        private void Ingresar_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
