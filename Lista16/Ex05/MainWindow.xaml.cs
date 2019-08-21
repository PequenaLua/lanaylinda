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

namespace Ex05
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular(object sender, RoutedEventArgs e)
        {
            Numeros x = new Numeros(int.Parse(txtInicio.Text), int.Parse(txtFim.Text));
            bool ini, fim;
            if (checkPares.IsChecked == true) { ini = true; }
            else ini = false;
            if (checkImpares.IsChecked == true) { fim = true; }
            else fim = false;
            lista.ItemsSource = x.Calcular(ini, fim);
        }
    }
}
