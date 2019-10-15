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

namespace Ex07___WPF
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
        private void OpenVeiculoWindow(object sender, RoutedEventArgs e)
        {
            VeiculoWindow j2 = new VeiculoWindow();
            j2.Show();
        }
        Loja l;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            l = new Loja(nomeLoja.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = l.ListarPorFabricante();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = l.ListarPorModelo();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(l.Total().ToString(), "Total");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(l.BuscarPlaca(placa.Text).ToString());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = l.BuscarValor(decimal.Parse(valor.Text));
        }
    }
}
