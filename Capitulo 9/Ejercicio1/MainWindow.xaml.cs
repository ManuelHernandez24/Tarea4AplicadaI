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
using System.Collections;

namespace Ejercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

    public struct Producto
    {
        public String Nombre;
        public float Precio;
        public float Cantidad;
    }
        
        public MainWindow()
        {
            InitializeComponent();
            

        }
        private void CrearButton_Click (object sender, RoutedEventArgs e){
            Producto producto = new Producto();

            producto.Nombre = TextBoxNotaNombre.Text;
            producto.Cantidad = float.Parse (TextBoxNotaCantidad.Text);
            producto.Precio = float.Parse (TextBoxNotaPrecio.Text);

            MessageBox.Show($"Se ha guardado! Nombre: {producto.Nombre} Cantidad: {producto.Cantidad} Precio: {producto.Precio}");
            
        }


    }
}
