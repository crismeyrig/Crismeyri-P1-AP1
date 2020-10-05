using System;
using System.Collections.Generic;
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
using Crismeyri_P1_AP1.UI.Registro;
using Crismeyri_P1_AP1.UI.Consulta;

namespace Crismeyri_P1_AP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         private void RegistroCiudadesButton_Click(object sender, RoutedEventArgs e)
        {
            rCiudades rCiudades1 = new rCiudades();
            rCiudades1.Show();

        }

        private void ConsultaCiudadesButton_Click(object sender, RoutedEventArgs e)
        {
            cCiudades cCiudades1 = new cCiudades();
            cCiudades1.Show();

        }
       
        private void AyudaMenu_Click(object sender, RoutedEventArgs e)
        {
    }
}
}
    

