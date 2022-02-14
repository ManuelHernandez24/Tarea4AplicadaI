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

    public struct Dueno
    {
        public String Nombre;
    }
    public struct Mascosta
    {
        public String Nombre;
        public String TipoAnimal;
    }


        
        public MainWindow()
        {
            InitializeComponent();
            

        }
        private void CrearButton_Click (object sender, RoutedEventArgs e){
            Dueno dueno = new Dueno();
            Mascosta mascosta = new Mascosta();

            dueno.Nombre = TextBoxNotaDueno.Text;
            mascosta.Nombre = TextBoxNotaMascota.Text;
            mascosta.TipoAnimal = TextBoxNotaTipoAnimal.Text;

            MessageBox.Show($"Se ha guardado! Nombre del dueño: {dueno.Nombre } Nombre de la mascota: {mascosta.Nombre} Tipo de animal: {mascosta.TipoAnimal}");
            
        }
    }
}
