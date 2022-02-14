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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OrdenarButton_Click (object sender, RoutedEventArgs e){
            Nombres(TextBoxNotaCadena1.Text,TextBoxNotaCadena2.Text);
            
            
        }

        void Nombres(string cadena1, string cadena2)
        {
            Random obj = new Random();
            List<String> cadenas = new List<String>();
            {
                cadenas.Add(cadena1);
                cadenas.Add(cadena2);

                cadenas = cadenas.OrderBy(l => l).ToList();

                TextBoxNotaCadena3.Text = cadenas[0];
                TextBoxNotaCadena4.Text = cadenas[1];
            }
        }
    }
}
