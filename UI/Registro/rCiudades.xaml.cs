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
using Crismeyri_P1_AP1.BLL;
using Crismeyri_P1_AP1.Entidades;
using Crismeyri_P1_AP1.DAL;

namespace Crismeyri_P1_AP1.UI.Registro
{
public partial class rCiudades : Window
    {
        private Ciudades ciudades = new Ciudades();
        public rCiudades()
        {
            InitializeComponent();
            this.DataContext = ciudades;
        }
        //Limpiar
        private void Limpiar()
        {
            this.ciudades = new Ciudades();
            this.DataContext = ciudades;
        }
        //validar
        private bool Validar()
        {
            bool esValido = true;
            if (CiudadIdTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallida", "La Ciudad no existe", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }
        //buscar
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var usuarios = CiudadesBLL.Buscar(Utilidades.ToInt(CiudadIdTextbox.Text));
            if (ciudades != null)
                this.ciudades = usuarios;
            else
                this.ciudades = new Ciudades();

            this.DataContext = this.ciudades;
        }
        //nuevo
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //guardar
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = CiudadesBLL.Guardar(ciudades);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa!", "Se ha guardado correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Fallida", "Debe ingresar la ciudad", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //eliminar
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (CiudadesBLL.Eliminar(Utilidades.ToInt(CiudadIdTextbox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado!", "Se ha eliminado  correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}